using ds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.Services
{
    public interface IFiliereService
    {
        IEnumerable<Filiere> Findll();
        
    }
}
