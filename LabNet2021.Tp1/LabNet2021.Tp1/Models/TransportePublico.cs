using LabNet2021.Tp1.Interface;

namespace LabNet2021.Tp1
{
    public abstract class TransportePublico : ITransportePublico
    {
        public TransportePublico()
        {

        }

        public TransportePublico(int numeroPasajeros)
        {
            CantidadPasajeros = numeroPasajeros;    
        }

        public int CantidadPasajeros { get; set; }

        public abstract string Avanzar();

        public abstract string Detenerse();

        public abstract string AnunciarFormasDePagoAceptadas();

        public abstract string AnunciarCantidadPasajeros(int numeroPasajeros);
        
    }   
}
