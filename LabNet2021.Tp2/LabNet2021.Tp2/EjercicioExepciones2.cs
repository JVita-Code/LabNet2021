using System;

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
        public int Denominador
        {
            get { return denominador; }
        }      
        
        public static int Division(int numerador)
        {
            int resultado = numerador / 0;
            return resultado;         
        }

        public static int Division(int numerador, int denominador)
        {
            int resultado = numerador / denominador;
            return resultado;
        }
    }


}


