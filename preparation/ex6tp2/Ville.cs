using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6tp2
{
    class Ville
    {

        private String nomVille;
        private String codeDepartement;
        private String codeCommune;

        //Constructeur
        public Ville(String pNomVille, String pCodeDepartement, String pCodeCommune)
        {
            this.NomVille = pNomVille;
            this.CodeDepartement = pCodeDepartement;
            this.CodeCommune = pCodeCommune;
        }

        public String NomVille
        {
            set;get;
        }

        public String CodeDepartement
        {
            get;set;
        }

        public String CodeCommune
        {
            get; set;
        }
    }
}
