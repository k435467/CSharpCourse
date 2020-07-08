using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class CondensedMilk: IngredientDecorator
    {
        Sweet sweet;
        public CondensedMilk(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("¥D®Æ") >= 0)
                    return sweet.Description.Replace("¥D®Æ", "·Ò¨Å");
                if (sweet.Description.IndexOf("+·Ò¨Å") >= 0)
                    return sweet.Description.Replace("+·Ò¨Å", "++·Ò¨Å");
                return sweet.Description + " +·Ò¨Å";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

