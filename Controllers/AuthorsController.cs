using CRUD_UoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.Controllers
{
    internal class AuthorsController
    {
        DBContext _context;
        UoW _uow;

        public AuthorsController(DBContext context)
        {
            _context = context;
            _uow = new UoW(_context);
        }

        public virtual IEnumerable<Author> GetList()
        {
            return _uow.Authors.GetList();
        }

        public virtual Author GetSingle(int id)
        {
            return _uow.Authors.GetSingle(id);
        }

        public virtual Author Add(Author author)
        {
            var added = _uow.Authors.Add(author);
            _uow.Save();
            return added;
        }

        public virtual void Update(Author author)
        {
            _uow.Authors.Update(author);
            _uow.Save();
        }

        public virtual void Delete(int id)
        {
            _uow.Authors.Delete(id);
            _uow.Save();
        }
    }
}
