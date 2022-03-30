using System;

namespace LabNet2021.Tp2
{
    public class CustomException : Exception
    {
        public CustomException(string mensajeDeError) : base(mensajeDeError)
        {
        }        
    }
}
