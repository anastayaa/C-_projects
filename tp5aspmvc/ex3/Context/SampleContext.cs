using ex7.Models;
using System.Data.Entity;

namespace ex7.Context
{
    public class SampleContext:DbContext
    {
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
    }
}