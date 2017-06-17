using System.Collections.Generic;

namespace Minerador.Dominio
{
    public partial class ArquivoPdb
    {
        public string Caminho { get; set; }
        public IList<Atomo> Atomos { get; set; }
        public IList<Atomo> Heteroatomos { get; set; }
    }
}
