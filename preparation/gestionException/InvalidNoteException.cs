using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionException
{
    class InvalidNoteException:Exception
    {
        public InvalidNoteException() : base() { }

        public InvalidNoteException(String message) : base(message)
        {
        }

        //Redéfinition de la propriété Message
        public override string Message 
        {
            get
            {
                return "La note doit être entre 0 et 20";
            }
        }
    }
}
