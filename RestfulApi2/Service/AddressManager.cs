using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Repository;

namespace TestApi.Service
{
    public class AddressManager : IAddressService
    {
        private readonly IGenericRepository<Address> _repository;
        public AddressManager(IGenericRepository<Address> repository)
        {
            _repository = repository;
        }
        public Address Create(Address address)
        {
            return _repository.Add(address);
        }

        public Address DeleteAddress(int id)
        {
            var deleteAddress = _repository.GetById(id);
            return _repository.Delete(deleteAddress);
        }

        public List<Address> GetAll()
        {
            return _repository.GetAll();
        }

        public Address GetAddress(int id)
        {
            return _repository.GetById(id);
        }

        public Address Update(int id, Address address)
        {
            return _repository.UpdateById(address, id);
        }
    }
}
