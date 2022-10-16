using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Service;

namespace TestApi.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController: ControllerBase
    {
        private readonly ICategoryService _categoryservice;
        public CategoryController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            var response = _categoryservice.Create(category);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetCategory(int id)
        {
            var response = _categoryservice.GetCategory(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _categoryservice.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteCategory(int id)
        {
            return Ok(_categoryservice.DeleteCategory(id));
        }
        [HttpPut("{id}")]
        public ActionResult UpdateCategory(int id, Category category)
        {
            var response = _categoryservice.Update(id, category);
            return Ok(response);
        }
    }
}
