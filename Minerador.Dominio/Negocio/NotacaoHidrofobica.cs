using System.Collections.Generic;
using System.Linq;

namespace Minerador.Dominio
{
    public partial class NotacaoHidrofobica
    {
        private static IList<NotacaoHidrofobica> _classificacaoHidrofobica =
            new List<NotacaoHidrofobica>()
            {
                new NotacaoHidrofobica("ALA", "CB"),
                new NotacaoHidrofobica("ARG", "CB"),
                new NotacaoHidrofobica("ARG", "CG"),
                new NotacaoHidrofobica("ARG", "CD"),
                new NotacaoHidrofobica("ARG", "CZ"),
                new NotacaoHidrofobica("ASN", "CB"),
                new NotacaoHidrofobica("ASN", "CG"),
                new NotacaoHidrofobica("ASP", "CB"),
                new NotacaoHidrofobica("ASP", "CG"),
                new NotacaoHidrofobica("CYS", "CB"),
                new NotacaoHidrofobica("GLN", "CB"),
                new NotacaoHidrofobica("GLN", "CG"),
                new NotacaoHidrofobica("GLN", "CD"),
                new NotacaoHidrofobica("GLU", "CB"),
                new NotacaoHidrofobica("GLU", "CG"),
                new NotacaoHidrofobica("GLU", "CD"),
                new NotacaoHidrofobica("HIS", "CB"),
                new NotacaoHidrofobica("HIS", "CG"),
                new NotacaoHidrofobica("HIS", "CD2"),
                new NotacaoHidrofobica("HIS", "CE1"),
                new NotacaoHidrofobica("ILE", "CB"),
                new NotacaoHidrofobica("ILE", "CG1"),
                new NotacaoHidrofobica("ILE", "CG2"),
                new NotacaoHidrofobica("ILE", "CD1"),
                new NotacaoHidrofobica("LEU", "CB"),
                new NotacaoHidrofobica("LEU", "CG"),
                new NotacaoHidrofobica("LEU", "CD1"),
                new NotacaoHidrofobica("LEU", "CD2"),
                new NotacaoHidrofobica("LYS", "CB"),
                new NotacaoHidrofobica("LYS", "CG"),
                new NotacaoHidrofobica("LYS", "CD"),
                new NotacaoHidrofobica("LYS", "CE"),
                new NotacaoHidrofobica("MET", "CB"),
                new NotacaoHidrofobica("MET", "CG"),
                new NotacaoHidrofobica("MET", "SD"),
                new NotacaoHidrofobica("MET", "CE"),
                new NotacaoHidrofobica("PHE", "CB"),
                new NotacaoHidrofobica("PHE", "CG"),
                new NotacaoHidrofobica("PHE", "CD1"),
                new NotacaoHidrofobica("PHE", "CD2"),
                new NotacaoHidrofobica("PHE", "CE1"),
                new NotacaoHidrofobica("PHE", "CE2"),
                new NotacaoHidrofobica("PHE", "CZ"),
                new NotacaoHidrofobica("PRO", "CB"),
                new NotacaoHidrofobica("PRO", "CG"),
                new NotacaoHidrofobica("PRO", "CD"),
                new NotacaoHidrofobica("SER", "CB"),
                new NotacaoHidrofobica("THR", "CB"),
                new NotacaoHidrofobica("THR", "CG2"),
                new NotacaoHidrofobica("TRP", "CB"),
                new NotacaoHidrofobica("TRP", "CG"),
                new NotacaoHidrofobica("TRP", "CD1"),
                new NotacaoHidrofobica("TRP", "CD2"),
                new NotacaoHidrofobica("TRP", "CE2"),
                new NotacaoHidrofobica("TRP", "CE3"),
                new NotacaoHidrofobica("TRP", "CZ2"),
                new NotacaoHidrofobica("TRP", "CZ3"),
                new NotacaoHidrofobica("TRP", "CH2"),
                new NotacaoHidrofobica("TYR", "CB"),
                new NotacaoHidrofobica("TYR", "CG"),
                new NotacaoHidrofobica("TYR", "CD1"),
                new NotacaoHidrofobica("TYR", "CD2"),
                new NotacaoHidrofobica("TYR", "CE1"),
                new NotacaoHidrofobica("TYR", "CE2"),
                new NotacaoHidrofobica("TYR", "CZ"),
                new NotacaoHidrofobica("VAL", "CB"),
                new NotacaoHidrofobica("VAL", "CG1"),
                new NotacaoHidrofobica("VAL", "CG2")
            };

        public static bool AtomoHidrofobico(Atomo atomo)
        {
            return _classificacaoHidrofobica.Any(n => n.Residuo.Equals(atomo.Residuo) && n.Nome.Equals(atomo.Nome));
        }

        public NotacaoHidrofobica(string residuo, string nome)
            : this()
        {
            Residuo = residuo;
            Nome = nome;
        }

        public NotacaoHidrofobica()
        { }
    }
}
