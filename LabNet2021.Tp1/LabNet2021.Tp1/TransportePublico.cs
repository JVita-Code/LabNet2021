namespace LabNet2021.Tp1
{
    public abstract class TransportePublico
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

        public string Arrancar()
        {
            return "Este transporte arranca simplemente girando la llave";
        }
        public abstract string Avanzar();

        public abstract string Detenerse();
    }   
}
