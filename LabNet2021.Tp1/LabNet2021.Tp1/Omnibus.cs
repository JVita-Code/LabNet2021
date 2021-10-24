namespace LabNet2021.Tp1
{
    public class Omnibus : TransportePublico, IFormaPago   
    {
        public Omnibus(int numeroPasajeros) : base(numeroPasajeros)
        {

        }
        public override string Avanzar()
        {
            return $"Avanzo y estoy trasladando a {Pasajeros} pasajeros.";
        }
        public override string Detenerse()
        {
            return "Tocaron el timbre, deteniendome...";
        }

        public string PagoDeCliente()
        {
            return "El pago del cliente es a través de la Tarjeta SUBE";
        }
    }
}