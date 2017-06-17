using Minerador.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Minerador.Repositorio
{
    public class RepositorioArquivoPdb : Repositorio<RepositorioArquivoPdb>
    {
        private IList<ArquivoPdb> _arquivosPdb;

        private void CarregarArquivosPdb()
        {
            var caminhoArquivosPdb = ConfigurationManager.AppSettings["PDB/Caminho"];

            if (string.IsNullOrWhiteSpace(caminhoArquivosPdb))
            {
                throw new NullReferenceException(
                        "A chave \"PDB/Caminho\" não está presente no arquivo de configuração da aplicação."
                    );
            }

            if (!Directory.Exists(caminhoArquivosPdb))
            {
                throw new OperationCanceledException(
                        "O caminho informado na chave \"PDB/Caminho\" não existe. Operação cancelada."
                    );
            }

            var caminhos = Directory.GetFiles(caminhoArquivosPdb);

            foreach (var caminho in caminhos)
            {
                _arquivosPdb.Add(new ArquivoPdb(caminho));
            }
        }

        public RepositorioArquivoPdb()
        {
            _arquivosPdb = new List<ArquivoPdb>();
            CarregarArquivosPdb();
        }

        public IList<ArquivoPdb> ListarArquivosPdb()
        {
            return _arquivosPdb;
        }
    }
}
