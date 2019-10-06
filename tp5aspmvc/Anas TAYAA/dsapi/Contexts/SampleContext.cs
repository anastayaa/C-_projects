using dsapi.Models;
using System.Data.Entity;

namespace dsapi.Contexts
{
    public class SampleContext:DbContext
    {
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Filiere> Filieres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Etudiant>()
                .HasRequired<Filiere>(e => e.Filiere)
                .WithMany(f => f.Etudiants)
                .HasForeignKey<int>(e => e.FiliereId);
        }
    }
}