using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp2.Extensions
{
    public static class DoubleExtensions
    {
        
        public static double DivisionPrecisa(this double value, double numerador, double denominador)
        {
            double resultado = numerador / denominador;
            if (double.IsPositiveInfinity(resultado) | double.IsPositiveInfinity(resultado) | double.IsNegativeInfinity(resultado))
                throw new DivideByZeroException();
            return resultado;
        } 
    }
}






