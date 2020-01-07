using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public virtual Int64 Sku { get; set; }
        public virtual String Name { get; set; }
        public virtual List<Warehouses> Warehouses { get;set; }
    }
}
