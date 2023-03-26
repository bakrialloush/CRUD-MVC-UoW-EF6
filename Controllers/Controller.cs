using CRUD_UoW.Models;
using CRUD_UoW.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.Controllers
{
    internal abstract class Controller<T> where T : BaseModel
    {
        DBContext _context;
        UoW<T> _uow;

        public Controller(DBContext context)
        {
            _context = context;
            _uow = new UoW<T>(_context);
        }

        public virtual IEnumerable<T> GetList()
        {
            return _uow.Entity.GetList();
        }

        public virtual T GetSingle(int id)
        {
            return _uow.Entity.GetSingle(id);
        }

        public virtual T Add(T entity)
        {
            var added = _uow.Entity.Add(entity);
            _uow.Save();
            return added;
        }

        public virtual void Update(T entity)
        {
            _uow.Entity.Update(entity);
            _uow.Save();
        }

        public virtual void Delete(int id)
        {
            _uow.Entity.Delete(id);
            _uow.Save();
        }
    }
}
