using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Minerador.Dominio
{
    public partial class ArquivoPdb
    {
        public string Nome
        {
            get
            {
                return new Regex(@"([0-9][a-zA-Z0-9]{1,3})").Match(this.Caminho).Value;
            }
        }

        public ArquivoPdb(string caminho)
        {
            var atomos = EnumerarAtomosPorArquivo(caminho);

            Atomos = new List<Atomo>(atomos.Where(a => a.Tipo.Equals(TipoAtomo.Atomo)));
            Heteroatomos = new List<Atomo>(atomos.Where(a => a.Tipo.Equals(TipoAtomo.Heteroatomo)));
            Caminho = caminho;
        }

        private IEnumerable<Atomo> EnumerarAtomosPorArquivo(string caminho)
        {
            var arquivo = File.ReadLines(caminho);

            if (arquivo.Count() > 0)
            {
                foreach (var linha in arquivo)
                {
                    yield return Atomo.CriarAtomo(linha);
                }
            }
        }
    }
}
