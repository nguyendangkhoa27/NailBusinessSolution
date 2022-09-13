using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace NailProject.Data.Entities
{
    public class Products 
    {
        public int Id { set; get; }
        public decimal Price{ set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime CreateDate { set; get; }
        public List<ProductInCategory> ProductInCategories{ set; get; } 
        
        public List<OrderDetail> OrderDetail { set; get; }
    }
}
