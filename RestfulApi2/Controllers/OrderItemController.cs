using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Service;

namespace TestApi.Controllers
{
    [Route("api/orderitem")]
    [ApiController]
    public class OrderItemController: ControllerBase
    {
        //IOrderItemService _orderitemservice
        private readonly IOrderItemService _orderitemservice;
        public OrderItemController(IOrderItemService orderitemservice)
        {
            _orderitemservice = orderitemservice;
        }
        [HttpPost]
        public ActionResult Create(OrderItem orderitem)
        {
            var response = _orderitemservice.Create(orderitem);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetOrderItem(int id)
        {
            var response = _orderitemservice.GetOrderItem(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _orderitemservice.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteOrderItem(int id)
        {
            return Ok(_orderitemservice.DeleteOrderItem(id));
        }
        [HttpPut("{id}")]
        public ActionResult UpdateOrderItem(int id, OrderItem orderitem)
        {
            var response = _orderitemservice.Update(id, orderitem);
            return Ok(response);
        }
    }
}
