using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Repository;

namespace TestApi.Service
{
    public class OrderManager : IOrderService
    {
        private readonly IGenericRepository<Order> _repository;
        public OrderManager(IGenericRepository<Order> repository)
        {
            _repository = repository;
        }
        public Order Create(Order order)
        {
            return _repository.Add(order);
        }

        public Order DeleteOrder(int id)
        {
            var deleteOrder = _repository.GetById(id);
            return _repository.Delete(deleteOrder);
        }

        public List<Order> GetAll()
        {
            return _repository.GetAll();
        }

        public Order GetOrder(int id)
        {
            return _repository.GetById(id);
        }

        public Order Update(int id, Order order)
        {
            return _repository.UpdateById(order, id);
        }
    }
}
