using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Repository
{
    public interface IGenericRepository<T> where T: class, new()
    {
        //CRUD
        T Add(T entity);
        T Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
        T UpdateById(T entity, int id);
    }
}
