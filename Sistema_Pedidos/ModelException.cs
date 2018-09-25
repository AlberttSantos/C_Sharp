using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pedidos
{
    class ModelException : Exception
    {
        public ModelException(string msg) : base(msg)
        {

        }
    }
}
