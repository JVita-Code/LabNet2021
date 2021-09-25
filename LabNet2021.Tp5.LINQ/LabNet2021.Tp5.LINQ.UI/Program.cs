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

            ProductsLogic products = new ProductsLogic();
            CustomersLogic customers = new CustomersLogic();


            

            Console.WriteLine("Ingrese el numero del ejercicio que desee ejecutar (1 al 13).");
            Console.WriteLine("Ingrese 100 para detener la app");

            int seleccion = 100;

            
            while (seleccion != 0)
            {

                

                try
                {
                    seleccion = Convert.ToInt32(Console.ReadLine());

                    switch (seleccion)
                    {
                        case 1:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            Console.WriteLine("Ingrese una ID conformada por 5 letras.");
                            try
                            {
                                string ID = Console.ReadLine();
                                if (ID != null)
                                    Console.WriteLine("Customer: " + customers.ObtenerCustomer(ID).ContactName);
                                else
                                    throw new Exception();                                

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("ID no encontrada o formato incorrecto.");
                                
                            }                                  
                            break;
                        case 2:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var product in products.ObtenerProductosSinStock())
                            {
                                Console.WriteLine("Product Name: " + product.ProductName);
                                
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var product in products.ObtenerProductosConStockBaratos())
                            {
                                Console.WriteLine("Product Name: " + product.ProductName);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var customer in customers.ObtenerCustomersWA())
                            {
                                Console.WriteLine("Customer: " + customer.ContactName);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            Console.WriteLine("Producto ID 789: " + products.ObtenerUnProductoONingunoConId789());
                            break;
                        case 6:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var customer in customers.ObtenerCustomersConEscrituraDiferente())
                            {
                                Console.WriteLine($"Customer: {customer.ContactName.ToUpper()} - {customer.ContactName.ToLower()}");
                            }
                            break;
                        case 7:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var item in customers.JoinDeCustomersOrders())
                            {
                                Console.WriteLine($"CustomerID: {item.CustomerID} - {item.ContactName} - OrderID: {item.OrderID}");
                            }
                            break;
                        case 8:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var customer in customers.ObtenerPrimerosTresCustomersDeWA())
                            {
                                Console.WriteLine("Customer ID: " + customer.CustomerID + " -- " + "Contact Name: " + customer.ContactName);
                            }
                            break;
                        case 9:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var product in products.ObtenerProductosOrdenadosNombre())
                            {
                                Console.WriteLine("Product: " + product.ProductName);
                            }
                            break;
                        case 10:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var product in products.ProductsPorStock())
                            {
                                Console.WriteLine("Product: " + product.ProductName + " - " + product.UnitsInStock);
                            }
                            break;
                        case 11:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var item in products.JoinDeProductsCategories())
                            {
                                Console.WriteLine(item.ProductID + "--" + item.ProductName + " -- " + item.CategoryID + "--" + item.CategoryName);
                            }
                            break;
                        case 12:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            List<Product> listaProductos = products.ProductsPorStock().ToList(); 
                            
                            Console.WriteLine("Primer producto: " + products.ObtenerPrimerElementoDeLista(listaProductos).ProductName);
                            break;
                        case 13:
                            Console.WriteLine("Ha seleccionado la consulta " + seleccion);
                            foreach (var item in customers.AgrupaCustomersOrders())
                            {
                                Console.WriteLine(item.CustomerID+ "-" + item.ContactName + " Cantidad de ordenes: " + item.OrderAmount);
                            }
                            break;
                        case 0:
                            break;
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Error, asegúrese de colocar bien los datos");
                    Console.WriteLine("Ingrese un número del 1 al 13");
                }



            }

            





































            // -------------- instancias



            //hola.ObtenerProductosSinStock();

            //hola.ObtenerUnProductoONingunoConId789();

            //hola.ObtenerProductosOrdenadosNombre();

            //hola.ObtenerProductosOrdenadosPorPrecioUnidadMayor();

            //hola.ObtenerPrimerElementoListaProductos();



            //hola.ObtenerProductosOrdenadosPorPrecioUnidadMayor();


            //hola.ProductsPorStock();

            //hola.JoinDeProductsCategories();




            //hola1.ObtenerCustomer("BOLID");

            //hola1.ObtenerCustomersWA();

            //hola1.ObtenerPrimerosTresCustomersDeWA();

            //hola1.ObtenerCustomer();

            //hola1.JoinDeCustomersOrders();



            Console.ReadLine();

            



        }
    }
}
