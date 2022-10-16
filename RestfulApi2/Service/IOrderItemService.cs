using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Service
{
    public interface IOrderItemService
    {
        OrderItem Create(OrderItem orderitem);
        OrderItem GetOrderItem(int id);
        List<OrderItem> GetAll();
        OrderItem DeleteOrderItem(int id);
        OrderItem Update(int id, OrderItem orderitem);
    }
}
