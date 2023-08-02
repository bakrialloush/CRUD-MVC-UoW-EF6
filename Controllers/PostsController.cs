using CRUD_UoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.Controllers
{
    internal class PostsController
    {
        DBContext _context;
        UoW _uow;

        public PostsController(DBContext context)
        {
            _context = context;
            _uow = new UoW(_context);
        }

        public virtual IEnumerable<Post> GetList()
        {
            return _uow.Posts.GetList();
        }

        public virtual Post GetSingle(int id)
        {
            return _uow.Posts.GetSingle(id);
        }

        public virtual Post Add(Post post)
        {
            var added = _uow.Posts.Add(post);
            _uow.Save();
            return added;
        }

        public virtual void Update(Post post)
        {
            _uow.Posts.Update(post);
            _uow.Save();
        }

        public virtual void Delete(int id)
        {
            _uow.Posts.Delete(id);
            _uow.Save();
        }
    }
}
