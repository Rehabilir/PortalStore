using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Service
{
    public interface ISKUService
    {
        SKU Create(SKU sku);
        SKU GetSKU(int id);
        List<SKU> GetAll();
        SKU DeleteSKU(int id);
        SKU Update(int id, SKU sku);
    }
}
