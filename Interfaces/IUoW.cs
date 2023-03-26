using CRUD_UoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.Interfaces
{
    internal interface IUoW<T> : IDisposable where T : BaseModel
    {
        IRepository<T> Entity { get; }
        void Save();
    }
}
