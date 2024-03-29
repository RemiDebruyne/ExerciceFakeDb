﻿using ExerciceFakeDb.Data;
using ExerciceFakeDb.Models;
using ExerciceFakeDb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceFakeDb.Controllers
{
    public class MonkeyController : Controller
    {


        public MonkeyRepository Repository { get; set; }



        public MonkeyGenerator Generator { get; set; }

        public MonkeyController(IRepository<Monkey> repository, MonkeyGenerator generator)
        {

            Repository = (MonkeyRepository?)repository;
            Generator = generator;
        }
        public IActionResult Index()
        {
           

            return View(Repository.GetAll());
        }

        public string Add()
        {
            return "Pas encore implémenté";
        }

        public IActionResult Details(int id)
        {
            Monkey monkey = Repository.GetById(id);
            return View(monkey);
        }

        public IActionResult GenerateRandom()
        {
            Repository.Create(new Monkey()
            {
                Name = Generator.GenerateName(),
            });

            
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Repository.Delete(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
