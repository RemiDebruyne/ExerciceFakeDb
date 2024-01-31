using ExerciceFakeDb.Models;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ExerciceFakeDb.Data
{
    public class FakeDb
    {

        private List<string> _monkeyNames = new List<string>()
        {
                "Stuart",
                "Fitzgerald",
                "Bonsai",
                "Hariette",
                "Peanut",
                "Sawa",
                "Rafiki",
                "Thunderstomp",
                "Po",
                "Chen",
                "Pickles",
                "Jean",
                "Maurice",
                "Julian",
                "Fred",
                "Albert",
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                "Bonk",
                "Bingus",
                "Bongus",
                "Daenerys de typhon de la Maison Targaryen, première du nom, Reine de Meereen, Reine des Andals, de Rhoynar et des Premiers Hommes, Suzeraine des Sept Couronnes et Protectrice du Royaume, Khaleesi de la Grande Mer Herbeuse, Mère des Dragons, L'Imbrûlée"
        };
        private Random _rnd = new Random();
        private int _lastId { get; set; }
        public List<Monkey> Monkeys { get; set; }


        public int LastId { get; set; }
        public MonkeyGenerator MonkeyGenerator { get; set; }

        public FakeDb()
        {
            MonkeyGenerator = new MonkeyGenerator();
            Monkeys = new List<Monkey>()
            {

                //new Monkey() { Id = ++LastId, Name = "Bobby"},
                //new Monkey() { Id = ++LastId, Name = "Ouistiti"},
                //new Monkey() { Id = ++LastId, Name = "Nonstiti"},
                //new Monkey() { Id = ++LastId, Name = "Bing"},
                //new Monkey() { Id = ++LastId, Name = "Bong"},
                //new Monkey() { Id = ++LastId, Name = MonkeyGenerator.NameGenerateMonkey()},
                //new Monkey() { Id = ++LastId, Name = MonkeyGenerator.NameGenerateMonkey()},

            };

        }
    }
}
