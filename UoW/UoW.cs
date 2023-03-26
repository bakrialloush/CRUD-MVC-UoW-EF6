using CRUD_UoW.Interfaces;
using CRUD_UoW.Models;
using CRUD_UoW.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.UoW
{
    internal class UoW<T> : IUoW<T> where T : BaseModel
    {
        DBContext _context;
        IRepository<T> _entity;

        public UoW(DBContext context)
        {
            _context = context;
        }

        public IRepository<T> Entity => _entity ?? new Repository<T>(_context);

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
