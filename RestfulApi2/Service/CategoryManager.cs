using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Repository;

namespace TestApi.Service
{
    public class CategoryManager : ICategoryService
    {
        private readonly IGenericRepository<Category> _repository;
        public CategoryManager(IGenericRepository<Category> repository)
        {
            _repository = repository;
        }
        public Category Create(Category category)
        {
            return _repository.Add(category);
        }

        public Category DeleteCategory(int id)
        {
            var deleteCategory = _repository.GetById(id);
            return _repository.Delete(deleteCategory);
        }

        public List<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public Category GetCategory(int id)
        {
            return _repository.GetById(id);
        }

        public Category Update(int id, Category category)
        {
            return _repository.UpdateById(category, id);
        }
    }
}
