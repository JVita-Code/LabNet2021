using LabNet2021.Tp5.LINQ.Data;
using LabNet2021.Tp5.LINQ.Entities;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using LabNet2021.TP5.LINQ.Logic;

namespace LabNet2021.Tp5.LINQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            

            

            // -------------- instancias

            ProductsLogic hola = new ProductsLogic();

            hola.ObtenerProductosSinStock();

            //hola.ObtenerUnProductoONingunoConId789();

            //hola.ObtenerProductosOrdenadosNombre();

            //hola.ObtenerProductosOrdenadosPorPrecioUnidadMayor();

            //hola.ObtenerPrimerElementoListaProductos();



            //hola.ObtenerProductosOrdenadosPorPrecioUnidadMayor();


            //hola.ProductsPorStock();

            //hola.JoinDeProductsCategories();

            CustomersLogic hola1 = new CustomersLogic();


            //hola1.ObtenerCustomer("BOLID");

            //hola1.ObtenerCustomersWA();

            //hola1.ObtenerPrimerosTresCustomersDeWA();

            //hola1.ObtenerCustomer();

            //hola1.JoinDeCustomersOrders();



            Console.ReadLine();

            



        }
    }
}
