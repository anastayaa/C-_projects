using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, Ville> lesVille = new Dictionary<string, Ville>();
            EnsembleVille ensembleVille = new EnsembleVille(lesVille);
            ensembleVille.ajouterVille(new Ville("Meknes", "50000", "50000"));
            ensembleVille.ajouterVille(new Ville("Safi", "20160", "20160"));
            ensembleVille.AfficherEnsemble();
            Ville v = ensembleVille.getUneVille("Safi");
            if(v!=null)
            Console.WriteLine(v.NomVille);
            Console.WriteLine(ensembleVille.getCodePostal("Safii"));
        }
    }
}
