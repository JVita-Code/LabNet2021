using System;

namespace LabNet2021.Tp2
{
    public class Logic
    {
        public static void LanzarMetodo()
        {
            throw new Exception("Excepcion lanzada manualmente desde la clase Logic");
        }

        public static void LanzarCustomException()
        {
            throw new CustomException("Excepcion Custom lanzada desde la clase Logic");
        }

        public static int ValidarFormato(string input)
        {
            var datoValido = int.TryParse(input, out int cantidadIngresada);

            while (!datoValido)
            {
                Console.WriteLine("Error: Ingrese un número");
                datoValido = int.TryParse(Console.ReadLine(), out cantidadIngresada);
            }

            return cantidadIngresada;
        }
    }
}
