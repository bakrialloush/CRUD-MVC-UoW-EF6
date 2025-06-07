using CRUD_UoW.Models;
using System.Collections.Generic;

namespace CRUD_UoW.Interfaces
{
    public interface IRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetAll();
        T GetSingle(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
