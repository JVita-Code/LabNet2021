using LabNet2021.Tp5.LINQ.Data;
using LabNet2021.Tp5.LINQ.Entities;
using System;
using System.Linq;

namespace LabNet2021.Tp5.LINQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            NorthwindContext context = new NorthwindContext();


            //var query3 = from P in context.Products where (P.UnitsInStock = 0)

            var query2 = context.Products.Where(p => p.UnitsInStock == 0);

            //foreach (var product in query2)
            //{
            //    Console.WriteLine(product.ProductName);
            //}


            var query3 = (from product in context.Products
                          where product.UnitsInStock > 0 & product.UnitPrice > 3
                          select product.ProductName).ToList();

            //foreach (var product in query3)
            //{
            //    Console.WriteLine(product);
            //}

            var query4 = (from customer in context.Customers
                          where customer.Region == "WA"
                          select customer.ContactName);

            //foreach (var customer in query4)
            //{
            //    Console.WriteLine(customer);
            //}

            var query5 = context.Products.FirstOrDefault(p => p.ProductID == 789);

            //foreach (var product in query5)
            //{
            //    Console.WriteLine(product);
            //}

            Console.ReadLine();



        }
    }
}
