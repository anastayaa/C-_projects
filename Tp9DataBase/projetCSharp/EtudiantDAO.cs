using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    interface EtudiantDAO
    {
        bool addEtudiant(Etudiant etudiant);
        bool updateEtudiant(Etudiant etudiant);
        bool deleteEtudiant(int idEtudiant);
        List<Etudiant> getAllEtudiants(String tri);
    }

    interface FiliereDAO
    {
        bool addFiliere(Filiere filiere);
        bool updateFiliere(Filiere filiere);
        bool deleteFiliere(int idFiliere);
        List<Filiere> getAllFilieres();
    }

}
