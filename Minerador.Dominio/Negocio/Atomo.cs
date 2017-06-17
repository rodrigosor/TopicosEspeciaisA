using System;

namespace Minerador.Dominio
{
    public partial class Atomo
    {
        public static Atomo CriarAtomo(string linhaArquivoPdb)
        {
            if (!string.IsNullOrWhiteSpace(linhaArquivoPdb))
            {
                try
                {
                    var atomo = new Atomo();

                    atomo.Tipo = (linhaArquivoPdb.Substring(0, 6).Trim().Equals("ATOM") ? TipoAtomo.Atomo : TipoAtomo.Heteroatomo);
                    atomo.ID = Convert.ToInt32(linhaArquivoPdb.Substring(6, 5).Trim());
                    atomo.Nome = linhaArquivoPdb.Substring(12, 4).Trim().ToUpper();
                    atomo.Residuo = linhaArquivoPdb.Substring(17, 3).Trim().ToUpper();
                    atomo.X = Convert.ToDouble(linhaArquivoPdb.Substring(30, 8).Replace('.', ',').Trim());
                    atomo.Y = Convert.ToDouble(linhaArquivoPdb.Substring(38, 8).Replace('.', ',').Trim());
                    atomo.Z = Convert.ToDouble(linhaArquivoPdb.Substring(46, 8).Replace('.', ',').Trim());

                    return atomo;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new OperationCanceledException(
                            "A linha do arquivo Pdb não estava em uma tabulação válida."
                        );
                }
            }

            return null;
        }

        public bool Hidrofobico
        {
            get
            {
                return NotacaoHidrofobica.AtomoHidrofobico(this);
            }
        }

        public double CalcularDistanciaEuclidiana(Atomo atomo)
        {
            return Math.Sqrt(
                    ((this.X - atomo.X) * (this.X - atomo.X)) +
                    ((this.Y - atomo.Y) * (this.Y - atomo.Y)) +
                    ((this.Z - atomo.Z) * (this.Z - atomo.Z))
                );
        }
    }
}
