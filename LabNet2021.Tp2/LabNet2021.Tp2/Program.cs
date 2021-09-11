using System;
using LabNet2021.Tp2;

namespace LabNet2021.Tp2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("A continuación se realizará una division por 0");

            Console.WriteLine("Ingrese un Numerador");
            try
            {
                Divisiones.DivisionComun(int.Parse(Console.ReadLine()));
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No se puede dividir por cero.");
                Console.WriteLine($"Se ha capturado la excepción '{ex.GetType()}'");
                Console.WriteLine($"{ex.Message}");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se capturó una excepcion generica '{ex.GetType()}'");
                Console.WriteLine($"{ex.Message}");
            }
            

            finally
            {
                Console.WriteLine("El metodo DivisionComun ha finalizado");
            }

            Console.ReadLine();

            Console.WriteLine("El siguiente programa realizara una division");

            
            try
            {
                Console.WriteLine("A continuacion, ingrese numerador");

                int numeradorTEST = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("A continuacion, ingrese denominador");
                int denominadorTEST = Convert.ToInt32(Console.ReadLine());

                var resultado = Divisiones.DivisionCompleta(numeradorTEST, denominadorTEST);
                
                Console.WriteLine($"El resultado de la division es {resultado}");

            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Seguro ingresó letras o no ingresó nada! : {ex.GetType()}");
                Console.WriteLine("Vuelva a iniciar el programa.");




            }
            catch (DivideByZeroException excep)
            {
                Console.WriteLine($"Ni Messi puede dividir por cero: {excep.GetType()}");
                Console.WriteLine("Vuelva a iniciar el programa.");

            }

            finally
            {
                Console.WriteLine("El programa ha finalizado");
            }

            Console.ReadLine();

























            //var digiteNum = "Elija el numerador";
            //Console.WriteLine(digiteNum);

            //var input1 = Console.ReadLine();


            //if (int.TryParse(input1, out int numerador))
            //{
            //    numerador2 = numerador;
            //}
            //else
            //{
            //    Console.WriteLine($"{input1} no es un numero");

            //}

            //var digiteDen = "Elija el denominador";
            //Console.WriteLine(digiteDen);

            //var input2 = Console.ReadLine();



            //if (int.TryParse(input2, out int denominador))
            //{
            //    denominador2 = denominador;
            //}
            //else
            //{
            //    Console.WriteLine($"{input2} no es un numero");
            //}









            //EjerciciosExcepciones.Division();





            //Console.WriteLine("Hello World!");
            //var foo = Console.ReadLine();
            //if (int.TryParse(foo, out int number1))
            //{
            //    Console.WriteLine($"{number1} is a number");
            //}
            //else
            //{
            //    Console.WriteLine($"{foo} is not a number");
            //}
            //Console.WriteLine($"The value of the variable {nameof(number1)} is {number1}");
            //Console.ReadLine();



        }
    }
}
