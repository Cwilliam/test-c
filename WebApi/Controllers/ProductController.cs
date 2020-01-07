using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericController<Product>
    {
        public ProductController()
        {
            list =  Context.Context.Product;
        }

        [HttpGet("{filter?}")]
        public override IEnumerable<object> Get(Int64 id)
        {
            var lis = id == 0 ? Context.Context.Product.ToList() : Context.Context.Product.ToList().Where(w => w.Sku == id);

            var dados = from i in (lis) group new {
                sku = i.Sku,
                name = i.Name,
                inventory = new { quantity = i.Warehouses.Count,
                    warehouses = i.Warehouses
                },
                isMarketable = i.Warehouses.Count > 0
            } by i.Sku into i select i;

            return dados;

        }

        [HttpPost]
        public override IActionResult Post(Product product)
        {
            Context.Context.Product.Add(product);
            return Ok();
        }

        [HttpPut]
        public override IActionResult Update(Product product)
        {
            foreach(var i in Context.Context.Product)
            {
                if(i.Sku == product.Sku)
                {
                    Context.Context.Product = Context.Context.Product.Where(val => val.Sku != i.Sku).ToList();
                    Context.Context.Product.Add(product);
                }
            }

            return null;
        }

        [HttpDelete]
        public override IActionResult Delete(Int64 id)
        {
            foreach (var i in Context.Context.Product)
            {
                if (i.Sku == id)
                {
                    Context.Context.Product = Context.Context.Product.Where(val => val.Sku != id).ToList();
                }
            }
            return Ok();
        }
    }
}
