using Minerador.Dominio;
using System;
using System.Collections.Generic;

namespace Minerador.Repositorio
{
    public class RepositorioGrafo : Repositorio<RepositorioGrafo>
    {
        public Grafo ModelarGrafo(IList<Atomo> interfaceMolecular)
        {
            if (interfaceMolecular.Count.Equals(0))
            {
                throw new OperationCanceledException(
                        "A interface molecular está vazia. Operação cancelada."
                    );
            }

            var grafo = new Grafo
            {
                Vertices = new List<Atomo>(interfaceMolecular),
                Arestas = new List<Aresta>()
            };

            foreach (var vertice in grafo.Vertices)
            {
                foreach (var atomo in interfaceMolecular)
                {
                    var distancia = vertice.CalcularDistanciaEuclidiana(atomo);

                    if (distancia <= 7)
                    {
                        var aresta = new Aresta(vertice, atomo);

                        if (!grafo.Arestas.Contains(aresta))
                        {
                            grafo.Arestas.Add(aresta);
                        }
                    }
                }
            }

            return grafo;
        } 
    }
}
