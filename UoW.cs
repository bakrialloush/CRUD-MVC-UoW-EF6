using CRUD_UoW.Interfaces;
using CRUD_UoW.Models;
using CRUD_UoW.Repositories;
using System;
using System.Data.Entity;

namespace CRUD_UoW
{
    internal class UoW : IUoW
    {
        private readonly DBContext _context;
        private DbContextTransaction _transaction;

        public IRepository<Author> Authors => new Repository<Author>(_context);
        public IRepository<Post> Posts => new Repository<Post>(_context);

        public UoW(DBContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            if (_transaction != null)
            {
                _transaction = _context.Database.BeginTransaction();
            }
        }

        public void Save()
        {
            _context.SaveChanges();
            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Rollback()
        {
            if (_transaction == null)
            {
                _transaction.Rollback();
            }
        }

    }
}
