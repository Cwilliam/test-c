using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Warehouses
    {
        public virtual String Locality { get; set; }
        public virtual Int64 Quantity { get; set; }
        public virtual String Type { get; set; }
    }
}
