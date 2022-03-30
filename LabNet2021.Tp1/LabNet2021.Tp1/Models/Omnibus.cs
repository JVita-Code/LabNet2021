using LabNet2021.Tp1.Interface;

namespace LabNet2021.Tp1
{
    public class Omnibus : TransportePublico, ITransportePublico
    {
        public Omnibus()
        {

        }

        public Omnibus(int numeroPasajeros) : base(numeroPasajeros)
        {

        }

        public override string AnunciarCantidadPasajeros(int numeroPasajeros)
        {
            return $"Actualmente transportando a {numeroPasajeros} pasajeros";
        }

        public override string AnunciarFormasDePagoAceptadas()
        {
            return "Se acepta sólamente pago por tarjeta SUBE";
        }

        public override string Avanzar()
        {
            return $"Avanzando...";
        }

        public override string Detenerse()
        {
            return "Tocaron el timbre, deteniendome...";
        }        
    }
}