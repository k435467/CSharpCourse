using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    abstract class IngredientDecorator: Sweet
    {
        public abstract override string Description { get; }
    }
}
