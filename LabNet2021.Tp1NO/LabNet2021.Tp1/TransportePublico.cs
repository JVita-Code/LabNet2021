
namespace LabNet2021.Tp1
{
    public abstract class TransportePublico : ITransportePublico
    {
        private int pasajeros;

        public int Pasajeros
        {
            get => this.pasajeros;
        }

        public TransportePublico(int numeroPasajeros)
        {
            this.pasajeros = numeroPasajeros;
        }


        public virtual string Avanzar()
        {
            return "Estoy avanzando...";
        }

        public virtual string Detenerse()
        {
            return "Deteniendome...";
        }

        
    }
}
