using LabNet2021.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp4.EF.Logic
{
    class CustomersLogic : BaseLogic
    {
        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }
    }
}
