using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsTest
{
    class G<T>
    {
        private T g;
        public T Get<T>()
        {
            return g;
        }
    }
}
