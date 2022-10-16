using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Repository;

namespace TestApi.Service
{
    public class OrderItemManager : IOrderItemService
    {
        private readonly IGenericRepository<OrderItem> _repository;
        public OrderItemManager(IGenericRepository<OrderItem> repository)
        {
            _repository = repository;
        }
        public OrderItem Create(OrderItem orderitem)
        {
            return _repository.Add(orderitem);
        }

        public OrderItem DeleteOrderItem(int id)
        {
            var deleteOrderItem = _repository.GetById(id);
            return _repository.Delete(deleteOrderItem);
        }

        public List<OrderItem> GetAll()
        {
            return _repository.GetAll();
        }

        public OrderItem GetOrderItem(int id)
        {
            return _repository.GetById(id);
        }

        public OrderItem Update(int id, OrderItem orderitem)
        {
            return _repository.UpdateById(orderitem, id);
        }
    }
}
