using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class descriptionPersonne : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Description_Click(object sender, EventArgs e)
    {
        String nom = Nom.Text;
        String prenom = Prenom.Text;
        int age = Convert.ToInt32(Age.Text);

        ServiceReference1.Personne personne = new ServiceReference1.Personne();
        personne.Nom = nom;
        personne.Prenom = prenom;
        personne.Age = age;

        ServiceReference1.PersonneServiceClient personneServiceClient = new ServiceReference1.PersonneServiceClient();
        descriptionLabel.Text = personneServiceClient.DescriptionPersonne(personne);
    }
}