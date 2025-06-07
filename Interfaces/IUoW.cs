﻿using CRUD_UoW.Models;
using System;

namespace CRUD_UoW.Interfaces
{
    public interface IUoW : IDisposable
    {
        IRepository<Author> Authors { get; }
        IRepository<Post> Posts { get; }

        void BeginTransaction();
        void Rollback();
        void Save();
    }
}
