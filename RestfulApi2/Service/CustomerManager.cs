using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Repository;

namespace TestApi.Service
{
    public class CustomerManager : ICustomerService
    {
        private readonly IGenericRepository<Customer> _repository;
        public CustomerManager(IGenericRepository<Customer> repository)
        {
            _repository = repository;
        }
        public Customer Create(Customer customer)
        {
            return _repository.Add(customer);
            //logic işlem yacılıacak

            // long TCKN = customer.TCID;
            
            // string Ad,Soyad;
            // Ad = customer.FirstName;
            // Soyad = customer.LastName;
            // int DY = customer.BirthDate.Year;
            
            
            // Kimlik.KPSPublicSoapClient KK = new Kimlik.KPSPublicSoapClient();

            // if (KK.TCKimlikNoDogrulaAsync(TCKN, Ad, Soyad, DY))
            // {
            //     return _repository.Add(customer);
            // }
            // else
            // {
            //     return _repository.Add();
            // }
        }

        public Customer DeleteCustomer(int id)
        {
            var deleteCustomer = _repository.GetById(id);
            return _repository.Delete(deleteCustomer);
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return _repository.GetById(id);
        }

        public Customer Update(int id, Customer customer)
        {
            return _repository.UpdateById(customer, id);
        }
    }
}
