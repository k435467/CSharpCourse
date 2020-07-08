using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    public abstract class Sweet
    {
        protected string description = "Unknown Sweet";
        public abstract string Description { get; }
        public abstract int Cost();
    }
}
