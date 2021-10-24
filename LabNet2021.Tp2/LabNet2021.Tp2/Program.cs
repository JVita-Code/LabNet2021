using LabNet2021.Tp2.Extensions;
using System;
using System.Windows;

namespace LabNet2021.Tp2
{
    class Program
    {

        static void Main(string[] args)
        {
            var seleccion = 0;

            Console.WriteLine("Ingrese un número del 1 al 5 para elegir el ejercicio a seleccionar");
            seleccion = int.Parse(Console.ReadLine());
            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("A continuación se realizará una division por 0");
                    Console.WriteLine("Ingrese un Numerador");
                    try
                    {
                        Divisiones.Division(int.Parse(Console.ReadLine()));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Se ha capturado la excepción de tipo'{ex.GetType()}'");
                        Console.WriteLine($"Error info: {ex.Message}");
                        Console.WriteLine("No se puede dividir por cero.");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Se capturó una excepcion generica de tipo '{ex.GetType()}'");
                        Console.WriteLine($"Error info: {ex.Message}");
                    }
                    finally
                    {
                        Console.WriteLine("El método para dividir por 0 ha finalizado");
                    }                                        
                    break;

                case 2:
                    Console.WriteLine("El siguiente programa realizara una division entre dos números");
                    try
                    {
                        Console.WriteLine("Ingrese numerador");
                        int numeradorTEST = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("A continuacion, ingrese denominador");
                        int denominadorTEST = Convert.ToInt32(Console.ReadLine());
                        var resultado = Divisiones.Division(numeradorTEST, denominadorTEST);
                        Console.WriteLine($"El resultado de la division es {resultado}");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Seguro ingresó letras o no ingresó nada! : {ex.GetType()}");
                        Console.WriteLine($"Error info: {ex.Message}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Se ha capturado la excepción de tipo'{ex.GetType()}'");
                        Console.WriteLine($"Error info: {ex.Message}");
                        Console.WriteLine($"Ni Messi puede dividir por cero");
                    }
                    finally
                    {
                        Console.WriteLine("La division entre dos numeros ha finalizado");
                    }
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Se ejecutará el metodo extendido: DivisionPrecisa");
                    try
                    {
                        double resultadoExtendido = 0;
                        Console.WriteLine("Ingrese el numerador");
                        double numPreciso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el denominador");
                        double denomPreciso = double.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la division es: " + resultadoExtendido.DivisionPrecisa(numPreciso, denomPreciso));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                        Console.WriteLine($"Se ha capturado la excepción '{ex.GetType()}'");
                        Console.WriteLine($"{ex.Message}");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Usted ingresó una letra o no ingresó nada");
                        Console.WriteLine($"Error info: {ex.Message}");
                    }
                    finally
                    {
                        Console.WriteLine("El método extendido ha finalizado");
                    }
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Consigna 3: Llamando al metodo LanzarMetodo desde la clase Logic");
                    try
                    {
                        Logic.LanzarMetodo();
                    }
                    catch (Exception ex3)
                    {
                        Console.WriteLine($"Error info: {ex3.Message}");
                        Console.WriteLine($"Se ha producido una excepcion de tipo: {ex3.GetType()}");
                    }
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Ejercicio 4: Llamando a la excepcion personalizada...");
                    try
                    {
                        Logic.ThrowCustomException();
                    }
                    catch (CustomException ex5)
                    {
                        Console.WriteLine($"Se capturó la excepcion: {ex5.GetType()}");
                        MessageBox.Show(ex5.Message, "Excepcion personalizada");
                    }
                    Console.WriteLine("El programa ha finalizado");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Número incorrecto, ingrese nuevamente (1-5).");
                    seleccion = int.Parse(Console.ReadLine());
                    break;
            }            
        }
    }
}
