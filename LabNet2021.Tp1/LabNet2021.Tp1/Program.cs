using System;
using System.Collections.Generic;

namespace LabNet2021.Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cantidad = 0;
            const int CantidadDeTaxies = 5;
            const int CantidadMaximaPorTaxi = 7;
            const int CantidadMaximaPorOmnibus = 100;
            var nombreTransporte = "Taxi";
            var numero = 0;

            #region
            //-------- Para chequear el correcto funcionamiento de los métodos, descomentar ----

            //Omnibus colectivoo = new Omnibus(40);
            //Taxi taxiii = new Taxi(5);

            //var cole = colectivoo.Avanzar();
            //var coleDos = colectivoo.Detenerse();
            //var coleTres = colectivoo.PagoDeCliente();
            //var coleCuatro = colectivoo.Arrancar();

            //var taxi = taxiii.Avanzar();
            //var taxiDos = taxiii.Detenerse();
            //var taxiTres = taxiii.PagoDeCliente();
            //var taxiCuatro = taxiii.Arrancar();

            //Console.WriteLine(cole);
            //Console.WriteLine(coleDos);
            //Console.WriteLine(coleTres);
            //Console.WriteLine(coleCuatro);

            //Console.WriteLine(taxi);
            //Console.WriteLine(taxiDos);
            //Console.WriteLine(taxiTres);
            //Console.WriteLine(taxiCuatro);

            #endregion

            List<TransportePublico> transportes = new List<TransportePublico>();

            Console.WriteLine("A continuación se procederá a especificar la cantidad de pasajeros de cada taxi y omnibus.");
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla y luego ENTER para comenzar el programa");
            Console.ReadLine();

                try
                {

                    for (int i = 1; i < 11; i++)
                    {
                        if (i <= CantidadDeTaxies)
                        {
                            Console.WriteLine("Ingrese la cantidad de pasajeros para el Taxi " + i + ".");
                            cantidad = int.Parse(Console.ReadLine());
                            while (cantidad < 0 || cantidad > CantidadMaximaPorTaxi)
                            {
                                Console.WriteLine("Un taxi no puede tener menos de 0 pasajeros o más de 7 pasajeros");
                                Console.WriteLine("Por favor, Ingrese una cantidad valida para el Taxi " + i + ".");
                                cantidad = int.Parse(Console.ReadLine());
                            }
                            transportes.Add(new Taxi(cantidad));
                        }
                        else
                        {
                            Console.WriteLine("Ingrese la cantidad de pasajeros para el Omnibus " + (i - CantidadDeTaxies) + ".");
                            cantidad = int.Parse(Console.ReadLine());
                            while ((cantidad < 0 || cantidad > CantidadMaximaPorOmnibus))
                            {
                                Console.WriteLine("Un Omnibus no puede tener menos de 0 pasajeros o más de 100 pasajeros parados");
                                Console.WriteLine("Por favor, Ingrese una cantidad valida para el Omnibus " + (i - CantidadDeTaxies) + ".");
                                cantidad = int.Parse(Console.ReadLine());
                            }
                            transportes.Add(new Omnibus(cantidad));
                        }
                    }

                    Console.WriteLine("------------------------------------------------------------------");

                    foreach (var transporte in transportes)
                    {
                        numero = 1;
                        if (transporte.GetType().Name == nombreTransporte)
                        {
                            Console.WriteLine("El Taxi " + (transportes.IndexOf(transporte) + numero) + " traslada actualmente a: " + transporte.Pasajeros + " pasajeros.");
                            numero++;
                        }
                        else
                        {
                            Console.WriteLine("El Omnibus " + (transportes.IndexOf(transporte) - 4) + " traslada actualmente a: " + transporte.Pasajeros + " pasajeros.");
                            numero++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error:" + " " + ex.Message);                    
                }
                finally { Console.WriteLine("Programa finalizado"); }
                Console.ReadLine();            
        }            
    }
}


