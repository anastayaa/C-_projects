using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    interface DAOPerson
    {
        bool addPerson(Person person);
        List<Person> getAllPerson();
        bool updatePerson(Person person);
        bool deletePerson(int idPerson);
    }
}
