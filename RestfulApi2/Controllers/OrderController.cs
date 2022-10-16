using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Service;

namespace TestApi.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController: ControllerBase
    {
        //IOrderService _orderservice
        private readonly IOrderService _orderservice;
        public OrderController(IOrderService orderservice)
        {
            _orderservice = orderservice;
        }
        [HttpPost]
        public ActionResult Create(Order order)
        {
            var response = _orderservice.Create(order);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetOrder(int id)
        {
            var response = _orderservice.GetOrder(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _orderservice.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteOrder(int id)
        {
            return Ok(_orderservice.DeleteOrder(id));
        }
        [HttpPut("{id}")]
        public ActionResult UpdateOrder(int id, Order order)
        {
            var response = _orderservice.Update(id, order);
            return Ok(response);
        }
    }
}
