using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Data;

namespace TestApi.Repository
{
    public class EfRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _dbset;
        public EfRepository(DatabaseContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public T Add(T entity)
        {
            var result = new T();
            _dbset.Add(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public T Delete(T entity)
        {
            var result = new T();
            _dbset.Remove(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public List<T> GetAll()
        {
            var result = new List<T>();
            var list = _dbset.ToList();
            if (list != null)
                result = list;
            else
                result = null;
            return result;
        }

        public T GetById(int id)
        {
            var result = new T();
            result = _dbset.Find(id);
            return result;
        }

        public T UpdateById(T entity, int id)
        {
            var result = new T();
            var model = _dbset.Find(id);
            if (model == null)
                return null;

            _context.Entry(model).CurrentValues.SetValues(entity);


            //var response = _context.Entry(model);
            //response.State = EntityState.Modified;
            _context.SaveChanges();
            //result = response.Entity;
            //result = model;

            //return result;
            return model;
        }
    }
}
