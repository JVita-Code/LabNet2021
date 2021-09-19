using LabNet2021.Tp4.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabNet2021.Tp4.EF.Entities;

namespace LabNet2021.Tp4.EF.Logic
{
    class ProductsLogic
    {
        private readonly NorthwindContext context;

        public ProductsLogic()
        {
            context = new NorthwindContext();
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
    }
}
