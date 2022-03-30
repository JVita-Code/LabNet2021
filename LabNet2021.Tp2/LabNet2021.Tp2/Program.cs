using LabNet2021.Tp2.Extensions;
using System;
using System.Windows;

namespace LabNet2021.Tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número del 1 al 5 para elegir el ejercicio a seleccionar");

            var seleccion = Logic.ValidarFormato(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("A continuación se realizará una division por 0");
                    Console.WriteLine("Ingrese un Numerador");
                    
                    try
                    {
                        //No se utiliza TryParse por pedido del ejercicio...

                        Divisiones.Division(int.Parse(Console.ReadLine()));                        
                    }
                    catch (DivideByZeroException ex)
                    {
                        var listaMensajesError = MensajesDeError.ErrorDivisionPorCero(ex);

                        foreach (var mensaje in listaMensajesError)
                        {
                            Console.WriteLine(mensaje);
                            Console.WriteLine("");
                        }                           
                    }
                    catch (Exception ex)
                    {
                        var listaMensajesErrorGenericos = MensajesDeError.ErrorExcepcionGenerica(ex);

                        foreach (var mensaje in listaMensajesErrorGenericos)
                        {
                            Console.WriteLine(mensaje);
                            Console.WriteLine("");
                        }
                    }
                    finally
                    {
                        Console.WriteLine("El método para dividir por 0 ha finalizado");
                        Console.ReadLine();
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
                        var listaErrorFormato = MensajesDeError.ErrorFormato(ex);

                        foreach (var mensaje in listaErrorFormato)
                        {
                            Console.WriteLine(mensaje);
                            Console.WriteLine("");
                        }
                    }
                    catch (DivideByZeroException ex)
                    {
                        var listaMensajesError = MensajesDeError.ErrorDivisionPorCero(ex);

                        foreach (var mensaje in listaMensajesError)
                        {
                            Console.WriteLine(mensaje);
                            Console.WriteLine("");
                        }
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
                        var listaMensajesError = MensajesDeError.ErrorDivisionPorCero(ex);

                        foreach (var mensaje in listaMensajesError)
                        {
                            Console.WriteLine(mensaje);
                            Console.WriteLine("");
                        }
                    }
                    catch (FormatException ex)
                    {
                        var listaErrorFormato = MensajesDeError.ErrorFormato(ex);

                        foreach (var mensaje in listaErrorFormato)
                        {
                            Console.WriteLine(mensaje);
                            Console.WriteLine("");
                        }
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
                    catch (Exception ex)
                    {
                        var listaMensajesErrorGenericos = MensajesDeError.ErrorExcepcionGenerica(ex);

                        foreach (var mensaje in listaMensajesErrorGenericos)
                        {
                            Console.WriteLine(mensaje);
                            Console.WriteLine("");
                        }
                    }
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Ejercicio 4: Llamando a la excepcion personalizada...");
                    try
                    {
                        Logic.LanzarCustomException();
                    }
                    catch (CustomException ex)
                    {
                        Console.WriteLine($"Se capturó la excepcion: {ex.GetType()}");                        

                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        Console.WriteLine("El lanzamiento de la excepcion ha finalizado");                                              
                    }
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
