using CRUD_UoW.Interfaces;
using CRUD_UoW.Models;
using CRUD_UoW.Repositories;
using System;
using System.Data.Entity;

namespace CRUD_UoW
{
    internal class UoW : IUoW
    {
        DBContext _context;
        DbContextTransaction _transaction;

        public UoW(DBContext context)
        {
            _context = context;
        }

        public IRepository<Author> Authors => new Repository<Author>(_context);
        public IRepository<Post> Posts => new Repository<Post>(_context);

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Save()
        {
            _context.SaveChanges();
            _transaction.Commit();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

    }
}
