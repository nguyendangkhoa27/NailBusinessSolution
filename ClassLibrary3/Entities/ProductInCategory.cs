using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailProject.Data.Entities
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }
        public Products Product { set; get; }
        public int CategoryId { get; set; }
        public Category Category { set; get; }

    }
}
