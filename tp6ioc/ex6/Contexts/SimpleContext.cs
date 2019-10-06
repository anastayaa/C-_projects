using ex6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ex6.Contexts
{
    public class SampleContext : DbContext
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