using ExerciceFakeDb.Data;

namespace ExerciceFakeDb.Models
{
    public class MonkeyGenerator
    {
        public FakeDb FakeDb { get; set; }
        public List<string> MonkeyName { get; set; }

        public Random rnd { get; set; } = new Random();
        public MonkeyGenerator()
        {
            MonkeyName = new List<string>()
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
        }



        public string GenerateName()
        {
            return MonkeyName[rnd.Next(0, MonkeyName.Count)];
        }
    }
}
