using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Service;

namespace TestApi.Controllers
{
    [Route("api/sku")]
    [ApiController]
    public class SKUController: ControllerBase
    {
        private readonly ISKUService _skuservice;
        public SKUController(ISKUService skuservice)
        {
            _skuservice = skuservice;
        }
        [HttpPost]
        public ActionResult Create(SKU sku)
        {
            var response = _skuservice.Create(sku);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetSKU(int id)
        {
            var response = _skuservice.GetSKU(id);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _skuservice.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteSKU(int id)
        {
            return Ok(_skuservice.DeleteSKU(id));
        }
        [HttpPut("{id}")]
        public ActionResult UpdateSKU(int id, SKU sku)
        {
            var response = _skuservice.Update(id, sku);
            return Ok(response);
        }
    }
}
