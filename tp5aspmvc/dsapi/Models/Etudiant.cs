using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dsapi.Models
{
    public class Etudiant
    {
        [Key]
        [Required]
        public String Cne
        {
            get; set;
        }

        [Required]
        [StringLength(7, MinimumLength =3)]
        public String Nom
        {
            get; set;
        }

        [Required]
        public String Prenom
        {
            get; set;
        }

        public int FiliereId
        {
            get; set;
        }

        [Required]
        public Filiere Filiere
        {
            get; set;
        }
    }
}