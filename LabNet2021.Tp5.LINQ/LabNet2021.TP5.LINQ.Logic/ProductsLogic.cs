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

            var productos = context.Products.Where(p => p.UnitsInStock == 0).ToList();            

            return productos;
        }

        public List<Product> ObtenerProductosConStockBaratos()
        {
             var productosBaratos = (from product in context.Products
                              where product.UnitsInStock > 0 && product.UnitPrice > 3
                              select product).ToList();
            

            return productosBaratos;
        }

        public Product ObtenerUnProductoONingunoConId789()
        {
            var elemento = context.Products.Where(p => p.ProductID == 789).FirstOrDefault();

            
            return elemento;
        }

        public List<Product> ObtenerProductosOrdenadosNombre()
        {
            var listaProductos = context.Products.OrderBy(p => p.ProductName).ToList();
            

            return listaProductos;
        }
        public List<Product> ObtenerProductosOrdenadosPorPrecioUnidadMayor()
        {
            var listaProductos = (from product in context.Products
                           orderby product.UnitsInStock descending 
                           select product).ToList();

            
            return listaProductos;
        }

        public IEnumerable<Product> ProductsPorStock()
        {
            var listaProductos = from Products in context.Products
                                    orderby Products.UnitsInStock descending
                                    select Products;

            return listaProductos;
        }


        public IEnumerable<ProductsCategories> JoinDeProductsCategories()
        {
            var productsCategories = from Categories in context.Categories
                                     join Products in context.Products
                                     on Categories.CategoryID equals Products.CategoryID
                                     select new ProductsCategories
                                     {
                                         ProductID = Products.ProductID,
                                         ProductName = Products.ProductName,
                                         CategoryID = Categories.CategoryID,
                                         CategoryName = Categories.CategoryName
                                     };
            return productsCategories;
        }

        public Product ObtenerPrimerElementoDeLista(List<Product> listaProductos)
        {
            var elementoDeLista = listaProductos.First(); 

            return elementoDeLista;
        }
    }
    
}

