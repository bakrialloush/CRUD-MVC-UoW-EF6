using CRUD_UoW.Interfaces;
using CRUD_UoW.Models;
using CRUD_UoW.Repositories;

namespace CRUD_UoW
{
    internal class UoW : IUoW
    {
        DBContext _context;

        public UoW(DBContext context)
        {
            _context = context;
        }

        public IRepository<Author> Authors => new Repository<Author>(_context);
        public IRepository<Post> Posts => new Repository<Post>(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
