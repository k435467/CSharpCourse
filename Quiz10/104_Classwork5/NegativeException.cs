using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_Classwork5
{
    public class NegativeException : Exception
    {
        public NegativeException(string msg) : base(msg)
        {

        }
    }
}
