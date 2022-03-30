using System;
using System.Collections.Generic;

namespace LabNet2021.Tp1
{
    class Program
    {
        static void Main(string[] args)
        {       
            
            // La idea es que esta clase sólo se encargue del control del flujo de la applicación. 

            MensajesAlUsuarioPorConsola.PresentarAplicacion();           

            try
            {
                var listaTransporte = CargaDePasajeros.CrearListaTransportePublico();

                CargaDePasajeros.CargarPasajeros(listaTransporte);

                CargaDePasajeros.InformaCantidad(listaTransporte);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error:" + " " + ex.Message);
            }
            finally
            {
                MensajesAlUsuarioPorConsola.AplicacionFinalizada();
            }            
        }
    }
} 
      


