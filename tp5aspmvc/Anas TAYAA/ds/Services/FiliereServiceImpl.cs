using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ds.Contexts;
using ds.Models;

namespace ds.Services
{
    public class FiliereServiceImpl : IFiliereService
    {
        SampleContext db = new SampleContext();

        public IEnumerable<Filiere> Findll()
        {
            return db.Filieres.ToList();
        }
    }
}