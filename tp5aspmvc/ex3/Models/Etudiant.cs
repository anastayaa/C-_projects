using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ex7.Models
{
    public class Etudiant
    {
        [Key]
        public String Cne
        {
            get; set;
        }

        public String Nom
        {
            get; set;
        }
        
        public Filiere Filiere
        {
            get; set;
        }
    }
}