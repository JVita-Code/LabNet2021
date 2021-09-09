namespace LabNet2021.Tp1
{
    public class Taxi : TransportePublico, ITransportePublico
    {
        public Taxi(int numeroPasajeros) : base(numeroPasajeros)
        {

        }

        public override string Avanzar()
        {
            return $"Estoy transportando {Pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return "Deteniendome, debo cobrarle al cliente.";
        }

        public string PagoDeCliente()
        {
            return "El pago del cliente es con dinero en efectivo";
        }
    }
}