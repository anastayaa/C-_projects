using ds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.Services
{
    public interface IEtudiantService
    {
        IEnumerable<Etudiant> Findll();
        void Add(Etudiant etudiant);
        IEnumerable<Etudiant> GetEtudiantsByFiliere(int id);
        Etudiant GetEtudiantByCne(String cne);
    }
}
