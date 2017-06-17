using Minerador.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Minerador.Repositorio
{
    public class RepositorioProteina : Repositorio<RepositorioProteina>
    {
        public List<Atomo> ObterInterfaceMolecular(ArquivoPdb arquivoPdb)
        {
            List<Atomo> interfaceMolecular = new List<Atomo>();

            foreach (var atomo in arquivoPdb.Atomos)
            {
                foreach (var heteroatomo in arquivoPdb.Heteroatomos)
                {
                    var distancia = atomo.CalcularDistanciaEuclidiana(heteroatomo);

                    if (distancia <= 7)
                    {
                        if (!interfaceMolecular.Contains(atomo))
                        {
                            interfaceMolecular.Add(atomo);
                        }
                    }
                }
            }

            return interfaceMolecular.Where(a => a.Hidrofobico).ToList();
        }
    }
}
