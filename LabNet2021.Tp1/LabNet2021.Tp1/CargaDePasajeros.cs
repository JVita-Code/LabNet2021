using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp1
{
    public class CargaDePasajeros
    {
        private const int CantidadDeTaxis = 5;
        private const int CantidadDeOmnibus = 5;

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

            while (contador <= CantidadDeTaxis)
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

            while (contador <= CantidadDeOmnibus)
            {
                Console.WriteLine("Ingrese la cantidad de pasajeros para el Omnibus " + contador + ".");

                cantidad = int.Parse(Console.ReadLine()); // try.Parse

                while (cantidad < 0 || cantidad > cantidadMaximaParaOmnibus)
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

        public static void InformaCantidad(List<TransportePublico> listaTransporte)
        {
            
            foreach (var transporte in listaTransporte)
            {
                var numero = 1;               

                if(transporte.GetType() == typeof(Taxi))
                {
                    Console.WriteLine("El Taxi " + (listaTransporte.IndexOf(transporte) + numero) + " traslada actualmente a: " + transporte.Pasajeros + " pasajeros.");
                    numero++;
                }
                else
                {
                    Console.WriteLine("El Omnibus " + (listaTransporte.IndexOf(transporte) - 4) + " traslada actualmente a: " + transporte.Pasajeros + " pasajeros.");
                    numero++;
                }
            }
        }
    }
}
