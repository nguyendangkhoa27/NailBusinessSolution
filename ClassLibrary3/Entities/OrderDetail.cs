using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailProject.Data.Entities
{
    internal class OrderDetail
    {
            public int Id { get; set; }
            public int ProductId { get; set; }
            public string Quantity { get; set; }
            public decimal Price { set; get; }
            
    }
}
