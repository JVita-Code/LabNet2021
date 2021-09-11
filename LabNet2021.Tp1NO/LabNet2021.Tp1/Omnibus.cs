namespace LabNet2021.Tp1
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int numeroPasajeros) : base(numeroPasajeros)
        {

        }
        public override string Avanzar()
        {
            return $"Yo avanzo y puedo trasladar como maximo a {Pasajeros} pasajeros por tierra";
        }
        public override string Detenerse()
        {
            return "Deteniendome...";
        }

    }
}
