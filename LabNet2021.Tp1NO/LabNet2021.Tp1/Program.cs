using System;
using System.Collections.Generic;

namespace LabNet2021.Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cantidad = 0;
            var cantidadTaxi = 5;
            var nombreTransporte = "Taxi";
            var numero = 0;



            List<TransportePublico> transportes = new List<TransportePublico>();

            Console.WriteLine("A continuación se procederá a especificar la cantidad de pasajeros de cada taxi y omnibus.");
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para comenzar el programa");
            Console.ReadLine();



            try
            {

                for (int i = 1; i < 11; i++)
                {
                    if (i <= 5)
                    {
                        Console.WriteLine("Ingrese una cantidad positiva de pasajeros para el Taxi " + i);
                        cantidad = int.Parse(Console.ReadLine());
                        transportes.Add(new Taxi(cantidad));
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una cantidad positiva de pasajeros para el Omnibus " + (i - cantidadTaxi));
                        cantidad = int.Parse(Console.ReadLine());
                        transportes.Add(new Omnibus(cantidad));
                    }
                }

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
            catch (Exception e)
            {
                Console.WriteLine($"Ha ocurrido un error inesperado, se ha ingresado un numero negativo o al menos una letra.");
                Console.WriteLine("El programa se cerrará, intente nuevamente.");
            }

            Console.ReadLine();
        }
    }
}