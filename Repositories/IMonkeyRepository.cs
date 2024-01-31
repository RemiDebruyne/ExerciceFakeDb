using ExerciceFakeDb.Models;

namespace ExerciceFakeDb.Repositories
{
    public interface IMonkeyRepository
    {
        public void Add(Monkey entity);
        public List<Monkey> GetAll();
        public Monkey GetById(int id);
        public void Update(Monkey entity);
        public void Delete(int id);
    }
}
