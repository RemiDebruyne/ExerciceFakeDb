using ExerciceFakeDb.Data;
using ExerciceFakeDb.Models;
using System.Reflection.Emit;

namespace ExerciceFakeDb.Repositories
{
    public class MonkeyRepository : IMonkeyRepository
    {
        public MonkeyGenerator Generator { get; set; }
        private readonly ApplicationDbContext _context;
        public MonkeyRepository(ApplicationDbContext context, MonkeyGenerator generator)
        {
            _context = context;
            Generator = generator;

        }

        public void Create(Monkey entity)
        {
            _context.Add(entity);
            _context.SaveChanges();

        }
        public void Add(Monkey entity)
        {

            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var monkey = GetById(id);

            _context.Remove(monkey);
            _context.SaveChanges();
        }

        public List<Monkey> GetAll()
        {
            return _context.Set<Monkey>().ToList();
        }

        public Monkey? GetById(int id)
        {
            return _context.Set<Monkey>().FirstOrDefault(m => m.Id == id);

        }

        public void Update(Monkey entity)
        {
            throw new NotImplementedException();

        }
    }
}
