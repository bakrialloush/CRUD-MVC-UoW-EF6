using CRUD_UoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.Interfaces
{
    internal interface IUoW : IDisposable
    {
        IRepository<Author> Authors { get; }
        IRepository<Post> Posts { get; }
        void Save();
    }
}
