using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp2
{

    public class Divisiones
    {
        private int numerador;
        private int denominador;
        private int resultado;

        public Divisiones(int numerador)
        {
            this.numerador = numerador;            
        }

        public int Numerador { get; set; }
        public int Resultado { get; set; }


        public int Denominador
        {
            get { return denominador; }
        }

        
        

        public static void DivisionComun(int numerador)
        {           
            int resultado = numerador / 0;
        }

        public static int DivisionCompleta(int numerador, int denominador)
        {
            int resultado = numerador / denominador;
            return resultado;
        }

        
    }


}


