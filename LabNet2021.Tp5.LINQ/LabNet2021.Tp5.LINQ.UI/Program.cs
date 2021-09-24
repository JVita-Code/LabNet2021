using LabNet2021.Tp5.LINQ.Data;
using LabNet2021.Tp5.LINQ.Entities;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LabNet2021.Tp5.LINQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            NorthwindContext context = new NorthwindContext();

            var query1 = context.Customers.First();

            


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

            
            //var query5 = context.Products.FirstOrDefault(p => p.ProductID == 789); --- FUNCIONA???
                
            //    if(query5 == null)
            //    {
            //    throw new NullReferenceException();
            //    }

            var query6 = (from customer 
                          in context.Customers
                          select new { companyname = customer.CompanyName.ToLower(), COMPANYNAME = customer.CompanyName.ToUpper() }).ToList();

            //foreach (var customer in query6)
            //{
            //    Console.WriteLine(customer.companyname);                

            //}
            //foreach (var customer in query6)
            //{
            //    Console.WriteLine(customer.COMPANYNAME);
            //}

            //var query7 = from orders in context.Orders
            //             join Customer in context.Customers
            //             on orders.CustomerID equals customer.customerID


            var query8 = context.Customers.Take(3).ToList();

            //foreach (var customer in query8)
            //{
            //    Console.WriteLine(customer.CompanyName);
            //}

            var query10 = context.Products.OrderBy(p => p.ProductName);

            //foreach (var product in query9)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //var query11 = (from product in context.Products
            //               join categoria in context.Categories
            //               on product.CategoryID
            //               equals categoria.CategoryID
            //               group categoria by categoria.CategoryName into categoriasOrdenadas
            //               select categoriasOrdenadas.);

            //foreach (var categoria in query11)
            //{
            //    Console.WriteLine(categoria);
            //}
            

            Console.ReadLine();



        }
    }
}
