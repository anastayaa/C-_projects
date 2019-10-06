using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionStock
{
    class Article
    {
        private int numero;
        private string nom;
        private double prix;
        private int quantite;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }


        public Article() { }
        public Article(int n, string no, double p, int q)
        {
            numero = n;
            nom = no;
            prix = p;
            quantite = q;
        }
        public override string ToString()
        {
            return "\r\nNuméro: " + numero + "\r\nNom: " + nom + "\r\nPrix: " + prix + "\r\nQuantité: " + quantite;
        }
    }

}
