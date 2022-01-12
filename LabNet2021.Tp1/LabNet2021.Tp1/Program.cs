using System;
using System.Collections.Generic;

namespace LabNet2021.Tp1
{
    class Program
    {
        static void Main(string[] args)
        {           
            var listaTransporte = new List<TransportePublico>();

            MensajesAlUsuario.PresentarAplicacion();           

            try
            {
                var listaPasajeros = CargaDePasajeros.Cargar(listaTransporte);

                CargaDePasajeros.InformaCantidad(listaPasajeros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error:" + " " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Programa finalizado");
            }
            Console.ReadLine();
        }
    }
} 
      


