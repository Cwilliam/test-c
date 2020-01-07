using Models;
using System.Collections.Generic;

namespace Context
{
    public class Context 
    {
        public static List<Product> Product = new List<Product>()
            {
                new Product() {
                Name = "A",
                    Sku = 1,
                    Warehouses = new List<Warehouses> { }        
            }
        };
     
    }
}
