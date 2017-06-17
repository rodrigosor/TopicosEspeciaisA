using System.Collections.Generic;

namespace Minerador.Dominio
{
    public partial class Grafo
    {
        public IList<Atomo> Vertices { get; set; }
        public IList<Aresta> Arestas { get; set; }
    }
}
