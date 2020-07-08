using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class FenGuo: IngredientDecorator
    {
        Sweet sweet;
        public FenGuo(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("¥D®Æ") >= 0)
                    return sweet.Description.Replace("¥D®Æ", "¯»ã_");
                if (sweet.Description.IndexOf("+¯»ã_") >= 0)
                    return sweet.Description.Replace("+¯»ã_", "++¯»ã_");
                return sweet.Description + " +¯»ã_";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

