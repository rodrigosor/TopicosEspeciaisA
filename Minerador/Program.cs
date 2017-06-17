using Minerador.Repositorio;
using System.Linq;

namespace Minerador
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivosPdb = RepositorioArquivoPdb.Instancia.ListarArquivosPdb();

            var interfaceMolecular = RepositorioProteina.Instancia.ObterInterfaceMolecular(arquivosPdb.FirstOrDefault());
        }
    }
}
