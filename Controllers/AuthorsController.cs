using CRUD_UoW.Models;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_UoW.Controllers
{
    internal class AuthorsController
    {
        DBContext _context;

        public AuthorsController(DBContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<Author> GetList()
        {
            return _context.Authors.ToList();
        }

        public virtual Author GetSingle(int id)
        {
            return _context.Authors.Find(id);
        }

        public virtual Author Add(Author author)
        {
            using (var uow = new UoW(_context))
            {
                uow.BeginTransaction();
                try
                {
                    var added = uow.Authors.Add(author);
                    uow.Save();
                    return added;
                }
                catch
                {
                    uow.Rollback();
                    throw;
                }
            }
        }

        public virtual void Update(Author author)
        {
            using (var uow = new UoW(_context))
            {
                uow.BeginTransaction();
                try
                {
                    uow.Authors.Update(author);
                    uow.Save();
                }
                catch
                {
                    uow.Rollback();
                    throw;
                }
            }
        }

        public virtual void Delete(int id)
        {
            using (var uow = new UoW(_context))
            {
                uow.BeginTransaction();
                try
                {
                    uow.Authors.Delete(id);
                    uow.Save();
                }
                catch
                {
                    uow.Rollback();
                    throw;
                }
            }
        }
    }
}
