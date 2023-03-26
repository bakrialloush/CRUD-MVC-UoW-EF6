using CRUD_UoW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UoW.Interfaces
{
    internal interface IRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetList();
        T GetSingle(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
