using CRUD_UoW.Interfaces;
using CRUD_UoW.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CRUD_UoW.Repositories
{
    internal class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly DBContext _context;
        private readonly DbSet<T> _table;

        public Repository(DBContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetSingle(int id)
        {
            return _table.Find(id);
        }
        public T Add(T entity)
        {
            return _table.Add(entity);
        }

        public void Update(T entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entity = _table.Find(id);
            _table.Remove(entity);
        }
    }
}
