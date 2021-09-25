using LabNet2021.Tp5.LINQ.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LabNet2021.TP5.LINQ.Logic
{
    public class ProductsLogic : BaseLogic
    {
        
        public List<Product> ObtenerProductosSinStock()
        {

            var query2 = context.Products.Where(p => p.UnitsInStock == 0).ToList();

            foreach (var product in query2)
            {
                Console.WriteLine(product.ProductName);
            }

            return query2;


        }

        public List<Product> ObtenerProductosConStockBaratos()
        {
             var query3 = (from product in context.Products
                              where product.UnitsInStock > 0 && product.UnitPrice > 3
                              select product).ToList();
            //foreach (var product in query3)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            return query3;
        }

        public Product ObtenerUnProductoONingunoConId789()
        {
            var query5 = context.Products.FirstOrDefault(p => p.ProductID == 789);

            //if(query5 == null)
            // {
            //     throw new Exception();
            // }
            // else
            // {
            //     Console.WriteLine(query5);
            //     return query5;

            // }
            return query5;
        }

        public List<Product> ObtenerProductosOrdenadosNombre()
        {
            var query9 = context.Products.OrderBy(p => p.ProductName).ToList();
            //foreach (var product in query9)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            return query9;
        }
        public List<Product> ObtenerProductosOrdenadosPorPrecioUnidadMayor()
        {
            var query10 = (from product in context.Products
                           orderby product.UnitsInStock descending 
                           select product).ToList();

            //foreach (var product in query10)
            //{
            //    Console.WriteLine(product);
            //}
            //
            return query10;
        }
        //public List<Product> ObtenerCategoriasAsociadasProductos()
        //{
        //    var query11 = (from product in context.Products
        //                   join categ in context.Categories
        //                   on product.CategoryID
        //                   equals categ.CategoryID
        //                   group categ by categ.CategoryName into algo
        //                   select algo).ToList();

        //    return query11.ToList();
        //}

        public Product ObtenerPrimerElementoListaProductos()
        {
            var query12 = context.Products.First(); 

            return query12;
        }
    }

        



    //public List<Product> ProductosEnStockBaratos()
    //{
    //    var query3 = (from product in context.Products
    //                  where product.UnitsInStock > 0 & product.UnitPrice > 3
    //                  select product.ProductName).ToList();
    //    return query3;
    //}
}

