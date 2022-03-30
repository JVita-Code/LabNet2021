using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp1
{
    public class MensajesAlUsuarioPorConsola
    {
        public static void PresentarAplicacion()
        {
            Console.WriteLine("A continuación se procederá a especificar la cantidad de pasajeros de cada taxi y omnibus.");
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla y luego ENTER para comenzar el programa");
            Console.ReadLine();
        }

        public static void AplicacionFinalizada()
        {
            Console.WriteLine("Programa finalizado");

            Console.WriteLine("Presione una tecla para cerrar la aplicación");

            Console.ReadLine();
        }
    }
}
