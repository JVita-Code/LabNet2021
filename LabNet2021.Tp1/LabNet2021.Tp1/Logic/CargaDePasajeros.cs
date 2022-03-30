using System;
using System.Collections.Generic;

namespace LabNet2021.Tp1
{
    public class CargaDePasajeros
    {
        private const int MinimoPasajeros = 0;
        private const int MaximoParaCadaTipoTransporte = 5;
        private const int MaximoPasajerosOmnibus = 100;
        private const int MaximoPasajerosTaxi = 7;
        private const int MaximoListaTransporte = 10;
                   

        /// Esta clase está escribiendo en consola... por lo tanto no es escalable por fuera de aplicaciones de este tipo, es una decisión
        /// que tomé dado el ejercicio propuesto. 

        public static List<TransportePublico> CrearListaTransportePublico()
        {
            var listaTransporte = new List<TransportePublico>();

            return listaTransporte;
        }

        public static List<TransportePublico> CargarPasajeros(List<TransportePublico> listaTransporte)
        {
            var contador = 1;
            var contadorOmnibus = 1;

            for (int i = 1; i <= MaximoParaCadaTipoTransporte; i++)
            {                
                Console.WriteLine($"Ingrese la cantidad de pasajeros para el Taxi {contador}");                

                var cantidadIngresada = ValidarFormato(Console.ReadLine());

                while (!ValidarValor(cantidadIngresada, MaximoPasajerosTaxi))
                {
                    Console.WriteLine($"Un Taxi no puede tener menos de {MinimoPasajeros} pasajeros o más de {MaximoPasajerosTaxi} pasajeros");

                    Console.WriteLine($"Por favor, Ingrese una cantidad valida para el Taxi {contador}");

                    cantidadIngresada = ValidarFormato(Console.ReadLine());
                }

                listaTransporte.Add(new Taxi(cantidadIngresada));

                contador++;
            }

            while (contador >= MaximoParaCadaTipoTransporte && contador <= MaximoListaTransporte)
            {               
                Console.WriteLine($"Ingrese la cantidad de pasajeros para el Omnibus {contadorOmnibus}");

                var cantidadIngresada = ValidarFormato(Console.ReadLine());

                while (!ValidarValor(cantidadIngresada, MaximoPasajerosOmnibus))
                {
                    Console.WriteLine($"Un Omnibus no puede tener menos de {MinimoPasajeros} pasajeros o más de {MaximoPasajerosOmnibus} pasajeros");

                    Console.WriteLine($"Por favor, Ingrese una cantidad valida para el Omnibus {contadorOmnibus}");

                    cantidadIngresada = ValidarFormato(Console.ReadLine());
                }

                listaTransporte.Add(new Omnibus(cantidadIngresada));

                contador++;

                contadorOmnibus++;
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
                    Console.WriteLine($"La cantidad de pasajeros para el Taxi {contadorTaxi} es de { taxi.CantidadPasajeros}");

                    contadorTaxi++;
                }

                if (transporte is Omnibus omnibus)
                {
                    Console.WriteLine($"La cantidad de pasajeros para el Omnibus {contadorOmnibus} es de { omnibus.CantidadPasajeros}");

                    contadorOmnibus++;
                }
            }
        }

        private static bool ValidarValor(int valorIngresado, int maximo)
        {
            while (valorIngresado < 0 || valorIngresado > maximo)
            {
                return false;
            }

            return true;
        }

        private static int ValidarFormato(string input)
        {
            var datoValido = int.TryParse(input, out int cantidadIngresada);

            while (!datoValido)
            {
                Console.WriteLine("Ingrese un número válido.");
                datoValido = int.TryParse(Console.ReadLine(), out cantidadIngresada);
            }

            return cantidadIngresada;
        }
    }
}