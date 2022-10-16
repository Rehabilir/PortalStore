using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Service
{
    public interface IOrderService
    {
        Order Create(Order order);
        Order GetOrder(int id);
        List<Order> GetAll();
        Order DeleteOrder(int id);
        Order Update(int id, Order order);
    }
}
