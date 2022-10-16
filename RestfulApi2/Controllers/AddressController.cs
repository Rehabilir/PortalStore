using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Service;

namespace TestApi.Controllers
{
    [Route("api/address")]
    [ApiController]
    public class AddressController:ControllerBase
    {
        private readonly IAddressService _addressservice;
        public AddressController(IAddressService addressservice)
        {
            _addressservice = addressservice;
        }
        [HttpPost]
        public ActionResult Create(Address address)
        {
        
            var response = _addressservice.Create(address);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetAddress(int id)
        {
            var response = _addressservice.GetAddress(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _addressservice.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteAddress(int id)
        {
            return Ok(_addressservice.DeleteAddress(id));
        }
        [HttpPut("{id}")]
        public ActionResult UpdateAddress(int id, Address address)
        {
            var response = _addressservice.Update(id, address);
            return Ok(response);
        }
    }
}
