using ExerciceFakeDb.Data;
using ExerciceFakeDb.Models;
using ExerciceFakeDb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceFakeDb.Controllers
{
    public class MonkeyController : Controller
    {


        public MonkeyRepository Repository { get; set; }



        public MonkeyGenerator Generator { get; set; }

        public MonkeyController(MonkeyRepository repository, MonkeyGenerator generator)
        {

            Repository = repository;
            Generator = generator;
        }
        public IActionResult Index()
        {
            List<Monkey> monkeyList = Repository.GetAll();

            return View(monkeyList);
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
