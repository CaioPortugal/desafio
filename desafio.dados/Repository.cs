using System.Data.Entity;
using System.Linq;

namespace desafio.dados
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private Context _context = null;
        private DbSet<T> table = null;
        public Repository()
        {
            this._context = new Context();
            table = _context.Set<T>();
        }
        public Repository(Context _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return table;
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {

            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
