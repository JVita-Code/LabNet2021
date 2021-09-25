using LabNet2021.Tp5.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2021.TP5.LINQ.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public Customer ObtenerCustomer(string id)
        {
            var objetoCustomer = context.Customers.Where(ID => ID.CustomerID == id).SingleOrDefault();

            return objetoCustomer;

        }
        public List<Customer> ObtenerCustomersWA()
        {
            var todosCustomers = (from customer in context.Customers
                          where customer.Region == "WA"
                          select customer).ToList();


            //foreach (var customer in query4)
            //{
            //    System.Console.WriteLine(customer);
            //}

            return todosCustomers;

        }

        //public IEnumerable<CustomersOrders>

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

        public IEnumerable<CustomersOrders> JoinDeCustomersOrders()
        {
            DateTime fecha = DateTime.ParseExact(19970101.ToString(), "yyyyMMdd", null);

            var customersYOrders = from Customers in context.Customers
                                  join Orders in context.Orders
                                  on Customers.CustomerID equals Orders.CustomerID
                                  where Orders.OrderDate > fecha && Customers.Region == "WA"
                                  select new CustomersOrders
                                  {
                                      CustomerID = Customers.CustomerID,
                                      ContactName = Customers.ContactName,
                                      OrderID = Orders.OrderID
                                  };
            return customersYOrders;
        }

        public List<Customer> ObtenerPrimerosTresCustomersDeWA()
        {
            var primerosTresCustomers = context.Customers.Where(r => r.Region == "WA").Take(3).ToList(); ;

            //foreach (var customer in query8)
            //{
            //    System.Console.WriteLine(customer.ContactName);
            //}           

            return primerosTresCustomers;
        }

        public IEnumerable<CustomersOrders> AgrupaCustomersOrders()
        {
            var agrupaCustomerOrders = from Customers in context.Customers
                                       join Orders in context.Orders
                                       on Customers.CustomerID equals Orders.CustomerID
                                       group Customers by new
                                       {
                                           Customers.ContactName,
                                           Customers.CustomerID
                                       }
                                           into tablaResultante
                                       select new CustomersOrders
                                       {
                                           CustomerID = (string)tablaResultante.Key.CustomerID,
                                           ContactName = (string)tablaResultante.Key.ContactName,
                                           OrderAmount = tablaResultante.Count()
                                       };

            return agrupaCustomerOrders;
        }

    }




    
}
