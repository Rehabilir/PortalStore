using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Service
{
    public interface ICategoryService
    {
        Category Create(Category category);
        Category GetCategory(int id);
        List<Category> GetAll();
        Category DeleteCategory(int id);
        Category Update(int id, Category category);
    }
}
