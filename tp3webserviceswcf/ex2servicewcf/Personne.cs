using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ex2servicewcf
{
    [DataContract]
    public class Personne
    {
        [DataMember]
        public String Nom
        {
            get;
            set;
        }

        [DataMember]
        public String Prenom
        {
            get;
            set;
        }

        [DataMember]
        public int Age
        {
            get;
            set;
        }

    }
}