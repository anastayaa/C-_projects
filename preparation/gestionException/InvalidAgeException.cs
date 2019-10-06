using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionException
{
    class InvalidAgeException: Exception
    {
        public InvalidAgeException() : base()
        {
        }

        public InvalidAgeException(String message) : base(message)
        {
        }

        //Redéfinition de la propriété Message
        public override string Message 
        {
            get
            {
                return "L’âge doit être entre 18 et 26";
            }
        }
    }
}
