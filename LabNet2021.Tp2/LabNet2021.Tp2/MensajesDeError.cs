using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp2
{
    public class MensajesDeError
    {
        public static List<string> ErrorExcepcionGenerica(Exception ex)
        {
            var mensaje = $"Ha ocurrido un error de tipo {ex.GetType()}";

            var listaMensajes = new List<string>() { mensaje, ex.Message };

            return listaMensajes;            
        }

        public static List<string> ErrorDivisionPorCero(DivideByZeroException ex)
        {            
            var mensaje = $"Ha ocurrido un error de tipo {ex.GetType()}";

            var mensajeGracioso = "Sólo Chuck Norris divide por cero!";

            var listaMensajes = new List<string>() { mensaje, ex.Message, mensajeGracioso};

            return listaMensajes;
        }

        public static List<string> ErrorFormato(FormatException ex)
        {
            var mensajeGracioso = "Usted ingresó una letra o no ingresó nada";

            var listaMensajes = new List<string>() { mensajeGracioso, ex.Message };

            return listaMensajes;
        }        
    }
}
