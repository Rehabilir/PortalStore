using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Service;
//using Kimlik.;

namespace TestApi.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController: ControllerBase
    {
        private readonly ICustomerService _customerservice;
        public CustomerController(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            var response = _customerservice.Create(customer);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetCustomer(int id)
        {
            var response = _customerservice.GetCustomer(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _customerservice.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteCustomer(int id)
        {
            return Ok(_customerservice.DeleteCustomer(id));
        }
        [HttpPut("{id}")]
        public ActionResult UpdateCustomer(int id, Customer customer)
        {
            var response = _customerservice.Update(id, customer);
            return Ok(response);
        }
    }
}
