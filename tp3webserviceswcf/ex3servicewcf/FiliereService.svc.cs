using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ex3servicewcf
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "FiliereService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez FiliereService.svc ou FiliereService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class FiliereService : IFiliereService
    {
        DBDataContext db = new DBDataContext();

        public List<Filiere> getAllFilieres()
        {
            return db.Filiere.ToList();
        }
    }
}
