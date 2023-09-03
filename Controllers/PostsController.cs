using CRUD_UoW.Models;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_UoW.Controllers
{
    internal class PostsController
    {
        DBContext _context;

        public PostsController(DBContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<Post> GetList()
        {
            return _context.Posts.ToList();
        }

        public virtual Post GetSingle(int id)
        {
            return _context.Posts.Find(id);
        }

        public virtual Post Add(Post post)
        {
            using (var uow = new UoW(_context))
            {
                uow.BeginTransaction();
                try
                {
                    var added = uow.Posts.Add(post);
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

        public virtual void Update(Post post)
        {
            using (var uow = new UoW(_context))
            {
                uow.BeginTransaction();
                try
                {
                    uow.Posts.Update(post);
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
                    uow.Posts.Delete(id);
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
