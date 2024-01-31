using System.ComponentModel;

namespace ExerciceFakeDb.Models
{
    public class Monkey
    {
        public int Id {     get; set; }

        [DisplayName("Prénom")]
        public string Name { get; set; }
        public Monkey() { }
        public Monkey(string name) : this()
        {
            Name = name;
        }

    }
}
