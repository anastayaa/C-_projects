﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ex2servicewcf
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PersonneService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez PersonneService.svc ou PersonneService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class PersonneService : IPersonneService
    {
        public string DescriptionPersonne(Personne personne)
        {
            return personne.Nom + " " + personne.Prenom + " " + personne.Age;
        }
    }
}
