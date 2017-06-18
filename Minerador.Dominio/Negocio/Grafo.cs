using System.IO;
using System.Text;

namespace Minerador.Dominio
{
    public partial class Grafo
    {
        public void SalvarComoArquivo(string caminho)
        {
            var conteudo = new StringBuilder();

            foreach (var vertice in Vertices)
            {
                conteudo.AppendLine($"v {vertice.Residuo}{vertice.Nome}");
            }

            foreach (var aresta in Arestas)
            {
                conteudo.AppendLine($"e {aresta.A1.Residuo}{aresta.A1.Nome} {aresta.A2.Residuo}{aresta.A2.Nome}");
            }

            File.WriteAllText(caminho, conteudo.ToString());
        }
    }
}
