

namespace LabNet2021.Tp1
{
    public class Taxi : TransportePublico
    {
        public Taxi(int numeroPasajeros) : base(numeroPasajeros)
        {

        }

        public override string Avanzar()
        {
            return $"Estoy transportando: {Pasajeros} pasajeros";
        }

        public override string Detenerse()
        {
            return "Deteniendome, debo cobrarle al cliente";
        }
    }
}
