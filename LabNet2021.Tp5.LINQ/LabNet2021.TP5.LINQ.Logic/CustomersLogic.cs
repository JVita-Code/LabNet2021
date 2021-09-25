using LabNet2021.Tp5.LINQ.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2021.TP5.LINQ.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customer> ObtenerCustomersWA()
        {
            var query4 = (from customer in context.Customers
                          where customer.Region == "WA"
                          select customer).ToList();


            //foreach (var customer in query4)
            //{
            //    System.Console.WriteLine(customer);
            //}

            return query4;

        }

        //public List<Customer> ObtenerCustomerMayus()
        //{
        //    var query6 = (from customer
        //                  in context.Customers
        //                  select new { companyname = customer.CompanyName.ToLower(), COMPANYNAME = customer.CompanyName.ToUpper() }).ToList();

        //    //foreach (var customer in query6)
        //    //{
        //    //    System.Console.WriteLine(customer);
        //    //}

        //    return query6.ToList();

        //}



        public List<Customer> ObtenerPrimerosTresCustomersDeWA()
        {
            var query8 = context.Customers.Where(r => r.Region == "WA").Take(3).ToList(); ;

            //foreach (var customer in query8)
            //{
            //    System.Console.WriteLine(customer.ContactName);
            //}           

            return query8;
        }
    }



        //public void ObtenerCustomersConOrdenesAsociadas()
        //{
        //    var query9 = from customer in Customers
        //                 where 
        //}

    
}
