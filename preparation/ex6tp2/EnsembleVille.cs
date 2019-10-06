using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6tp2
{
    class EnsembleVille
    {
        private Dictionary<String, Ville> lesVilles;

        public EnsembleVille(Dictionary<String, Ville> lesVilles)
        {
            this.lesVilles = lesVilles;
        }

        /*retourne l'objet Ville dont le nom est passé 
        en paramètre, null si le nom n'est pas trouvé*/
        public Ville getUneVille(String unNomVille)
        {
            if(lesVilles.ContainsKey(unNomVille))
                return lesVilles[unNomVille];
            return null;
        }

        /*  si  une  ville  du  même  nom  est  déjà  présente 
        indiquer cela à l'utilisateur*/
        public void ajouterVille(Ville uneVille)
        {
            if (lesVilles.ContainsKey(uneVille.NomVille)){
                Console.WriteLine("Ooops, la ville existe deja");
            }
            else
            {
                lesVilles.Add(uneVille.NomVille, uneVille);
            }
        }

        /*Renvoie le code postal de la ville dont le nom est 
        passé en  paramètre,  "
        n'existe  pas
        "  si    la  ville  n'a 
        pas été trouvée*/
        public String getCodePostal(String unNomVille)
        {
            if(lesVilles.ContainsKey(unNomVille))
                return lesVilles[unNomVille].CodeCommune;
            return "Incunnu";
        }
        /*
        Affiche
        l'ensemble  par  ordre  croissant  des  noms  de 
        ville*/
        public void AfficherEnsemble()
        {
            // Acquire keys and sort them.
            var list = lesVilles.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                Console.WriteLine(lesVilles[key].NomVille + " " + lesVilles[key].CodeCommune + " " + lesVilles[key].CodeDepartement);
            }
        }
   }
}
