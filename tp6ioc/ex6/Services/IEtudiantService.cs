using ex6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6.Services
{
    public interface IEtudiantService
    {

        void Save(Etudiant etudiant);
        IEnumerable<Etudiant> findAll();
        Etudiant GetEtudiantByCne(string cne);

    }
}
