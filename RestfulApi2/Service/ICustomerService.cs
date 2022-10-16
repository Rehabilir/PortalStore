using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Service
{
    public interface ICustomerService
    {
        Customer Create(Customer customer);
        Customer GetCustomer(int id);
        List<Customer> GetAll();
        Customer DeleteCustomer(int id);
        Customer Update(int id, Customer customer);
    }
}
