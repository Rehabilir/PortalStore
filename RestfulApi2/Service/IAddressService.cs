using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Service
{
    public interface IAddressService
    {
        Address Create(Address address);
        Address GetAddress(int id);
        List<Address> GetAll();
        Address DeleteAddress(int id);
        Address Update(int id, Address address);
    }
}
