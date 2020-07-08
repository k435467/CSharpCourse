using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    class Iced: TemperatureDecorator
    {
        Sweet sweet;

        public Iced(Sweet sweet)
        {
            this.sweet = sweet;
        }

        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("豆花") >= 0)
                    return "冰 " + sweet.Description;
                return sweet.Description;
            }
        }

        public override int Cost()
        {
            return sweet.Cost();
        }
    }
}
