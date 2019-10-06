using ex1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ex1.Context
{
    public class DBEtudiantContext:DbContext
    {
        public DbSet<Etudiant> Etudiants { get; set; }
    }
}