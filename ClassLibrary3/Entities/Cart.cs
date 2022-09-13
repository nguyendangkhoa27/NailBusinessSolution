using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailProject.Data.Entities
{
    internal class Cart
    {
            public int Id { get; set; }
            public int ProductId { set; get; }
            public string Quantity { set; get; }
            public decimal Price { set; get; }  
    }
}
