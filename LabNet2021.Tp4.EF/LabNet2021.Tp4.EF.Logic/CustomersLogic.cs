using LabNet2021.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp4.EF.Logic
{
    class CustomersLogic : BaseLogic, IABMLogic<Customer>
    {
        public void Add(Customer field)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Update(Customer field)
        {
            throw new NotImplementedException();
        }
    }
}
