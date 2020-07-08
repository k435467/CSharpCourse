using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    class ShavedIce: Sweet
    {
        public ShavedIce()
        {
            description = "黑糖主料刨冰";
        }

        public override string Description 
        {
            get { return description; }
        }

        public override int Cost()
        {
            return 50;
        }
    }
}
