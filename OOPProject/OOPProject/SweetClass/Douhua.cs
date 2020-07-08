using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    class Douhua : Sweet
    {
        public Douhua()
        {
            description = "古早味主料豆花";
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
