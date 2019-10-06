using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    class Person
    {

        public Person()
        {
        }

        public Person(String name, String state)
        {
            Name = name;
            State = state;
        }
        public Person(String name, String state, int id_filiere)
        {
            Name = name;
            State = state;
            Id_filiere = id_filiere;
        }
        public Person(int id, String name, String state, int id_filiere)
        {
            Id = id;
            Name = name;
            State = state;
            Id_filiere = id_filiere;
        }

        public int Id
        {
            get;set;
        }
        public String Name
        {
            get;set;
        }
        public String State
        {
            get;set;
        }
        public int Id_filiere
        {
            get;set;
        }
    }
}
