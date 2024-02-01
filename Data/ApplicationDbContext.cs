using ExerciceFakeDb.Controllers;
using ExerciceFakeDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace ExerciceFakeDb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public MonkeyGenerator MonkeyGenerator { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, MonkeyGenerator generator) : base(options)
        {
            MonkeyGenerator = generator;
        }

        public DbSet<Monkey> Monkeys { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data source=(localdb)\\exerciceDB; Database=exerciceSinge;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // HasData permet d'ajouter des données dans la base lors de la création des tables
            modelBuilder.Entity<Monkey>().HasData(
                new Monkey() { Id = 1, Name = MonkeyGenerator.GenerateName() },
                new Monkey() { Id = 2, Name = MonkeyGenerator.GenerateName() },
                new Monkey() { Id = 3, Name = MonkeyGenerator.GenerateName() },
                new Monkey() { Id = 4, Name = MonkeyGenerator.GenerateName() }
                );
        }
    }
}
