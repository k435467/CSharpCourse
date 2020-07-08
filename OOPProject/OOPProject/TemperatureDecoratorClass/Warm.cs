using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    class Warm: TemperatureDecorator
    {
        Sweet sweet;

        public Warm(Sweet sweet)
        {
            this.sweet = sweet;
        }

        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("豆花") >= 0)
                    return "熱 " + sweet.Description;
                return "熱 " + sweet.Description;
            }
        }

        public override int Cost()
        {
            return sweet.Cost();
        }
    }
}
