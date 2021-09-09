namespace LabNet2021.Tp1
{
    public class Omnibus : TransportePublico
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
            return "Deteniendome...";
        }

    }
}