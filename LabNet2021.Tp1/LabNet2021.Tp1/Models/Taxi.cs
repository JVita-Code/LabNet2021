using LabNet2021.Tp1.Interface;

namespace LabNet2021.Tp1
{
    public class Taxi : TransportePublico, ITransportePublico
    {
        public Taxi()
        {

        }

        public Taxi(int numeroPasajeros) : base(numeroPasajeros)
        {

        }

        public override string AnunciarCantidadPasajeros(int numeroPasajeros)
        {
            return $"Actualmente transportando a {numeroPasajeros} pasajeros";
        }

        public override string AnunciarFormasDePagoAceptadas()
        {
            return "Se acepta sólamente pago en efectivo";
        }

        public override string Avanzar()
        {
            return $"Avanzando...";
        }

        public override string Detenerse()
        {
            return "Deteniendome, debo cobrarle al cliente.";
        }        
    }
}