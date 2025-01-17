﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ds.Models
{
    public class Filiere
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get; set;
        }

        [Required]
        public String Nom
        {
            get; set;
        }

        public ICollection<Etudiant> Etudiants { get; set; }
    }
}