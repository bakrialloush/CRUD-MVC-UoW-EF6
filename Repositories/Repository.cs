using CRUD_UoW.Interfaces;
using CRUD_UoW.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.Repositories
{
    internal class Repository<T> : IRepository<T> where T : BaseModel
    {
        DBContext _context;
        DbSet<T> _table;

        public Repository(DBContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public IEnumerable<T> GetList()
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
