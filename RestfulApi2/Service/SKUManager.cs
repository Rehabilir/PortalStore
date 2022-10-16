using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Repository;

namespace TestApi.Service
{
    public class SKUManager : ISKUService
    {
        private readonly IGenericRepository<SKU> _repository;
        public SKUManager(IGenericRepository<SKU> repository)
        {
            _repository = repository;
        }
        public SKU Create(SKU sku)
        {
            return _repository.Add(sku);
        }

        public SKU DeleteSKU(int id)
        {
            var deleteSKU = _repository.GetById(id);
            return _repository.Delete(deleteSKU);
        }

        public List<SKU> GetAll()
        {
            return _repository.GetAll();
        }

        public SKU GetSKU(int id)
        {
            //logic işlem yapılabilir 
            return _repository.GetById(id);
        }

        public SKU Update(int id, SKU sku)
        {
            return _repository.UpdateById(sku, id);
        }
    }
}
