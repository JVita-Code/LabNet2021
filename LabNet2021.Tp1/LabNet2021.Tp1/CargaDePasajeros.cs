using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp1
{
    public class CargaDePasajeros
    {
        private const int CantidadMaximaDeTaxis = 5;
        private const int CantidadMaximaDeOmnibus = 5;

        public static List<TransportePublico> Cargar(List<TransportePublico> listaTransporte)
        {
            var listaPasajeros = CargarPasajerosTaxi(listaTransporte);
            var listaCargada = CargarPasajerosOmnibus(listaPasajeros);
            return listaCargada;
        }       

        public static List<TransportePublico> CargarPasajerosTaxi(List<TransportePublico> listaTransporte)
        {            
            var contador = 1;
            var cantidad = 0;
            var cantidadMaximaParaTaxi = 7;

            while (contador <= CantidadMaximaDeTaxis)
            {
                Console.WriteLine("Ingrese la cantidad de pasajeros para el Taxi " + contador + ".");

                cantidad = int.Parse(Console.ReadLine()); // try.Parse

                while (cantidad < 0 || cantidad > cantidadMaximaParaTaxi)
                {
                    Console.WriteLine("Un taxi no puede tener menos de 0 pasajeros o más de 7 pasajeros");
                    Console.WriteLine("Por favor, Ingrese una cantidad valida para el Taxi " + contador + ".");
                    cantidad = int.Parse(Console.ReadLine());
                }

                listaTransporte.Add(new Taxi(cantidad));
                contador++;
            }
            return listaTransporte;
        }

        public static List<TransportePublico> CargarPasajerosOmnibus(List<TransportePublico> listaTransporte)
        {

            var contador = 1;
            var cantidad = 0;
            var cantidadMaximaParaOmnibus = 100;

            while (contador <= CantidadMaximaDeOmnibus)
            {
                Console.WriteLine("Ingrese la cantidad de pasajeros para el Omnibus " + contador + ".");

                cantidad = int.Parse(Console.ReadLine()); // try.Parse

                while (cantidad < 0 || cantidad > cantidadMaximaParaOmnibus)
                {
                    Console.WriteLine("Un taxi no puede tener menos de 0 pasajeros o más de 7 pasajeros");
                    Console.WriteLine("Por favor, Ingrese una cantidad valida para el Taxi " + contador + ".");
                    cantidad = int.Parse(Console.ReadLine());
                }

                listaTransporte.Add(new Omnibus(cantidad));
                contador++;
            }
            return listaTransporte;
        }

        public static void InformaCantidad(List<TransportePublico> listaTransporte)
        {

            //foreach (var transporte in listaTransporte)
            //{
            //    var numero = 1;               

            //if (transporte.GetType() == typeof(Taxi))
            //{
            //    numero++;
            //    Console.WriteLine("El Taxi " + listaTransporte.IndexOf(transporte) + numero) + " traslada actualmente a: " + transporte.Pasajeros + " pasajeros.");
            //}
            //else
            //{
            //    Console.WriteLine("El Omnibus " + (listaTransporte.IndexOf(transporte) - numero) + " traslada actualmente a: " + transporte.Pasajeros + " pasajeros.");
            //}
            //}

            //foreach (TransportePublico transporte in listaTransporte)
            //{

            //    Console.WriteLine($"El {transporte.GetType().Name} {listaTransporte.IndexOf(transporte)} tiene {transporte.Pasajeros} pasajeros");                
            //}

            for (int i = 1; i < listaTransporte.Count; i++)
            {
                Console.WriteLine($"El {listaTransporte[i].GetType().Name} {i} traslada actualmente a {listaTransporte[i].Pasajeros}");
            }

        }
    }
}
