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
            
            var cantidadMaximaParaTaxi = 7;

            while (contador <= CantidadMaximaDeTaxis)
            {
                var cantidad = 0;

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
            var cantidadMaximaParaOmnibus = 100;

            while (contador <= CantidadMaximaDeOmnibus)
            {
                var cantidad = 0;

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
            var contadorTaxi = 1;
            var contadorOmnibus = 1;            

            foreach (var transporte in listaTransporte)
            {                
                if (transporte is Taxi taxi)
                {
                    var cantidad = taxi.Pasajeros;
                    Console.WriteLine("La cantidad de pasajeros para el Taxi " + contadorTaxi + " es de " + cantidad + ".");
                    contadorTaxi++;
                }
                else if (transporte is Omnibus omnibus)
                {
                    var cantidad = omnibus.Pasajeros;
                    Console.WriteLine("La cantidad de pasajeros para el Omnibus " + contadorOmnibus + " es de " + cantidad + ".");
                    contadorOmnibus++;
                }                
            }
        }
    }
}
