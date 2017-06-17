namespace Minerador.Dominio
{
    public partial class Atomo
    {
        public TipoAtomo Tipo { get; set; }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Residuo { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
