using System;

namespace LabNet2021.Tp2
{
    class CustomException : Exception
    {
        public CustomException() : base("Ha ocurrido una excepcion personalizada")
        {

        }
    }
}
