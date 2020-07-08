using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class Pearl: IngredientDecorator
    {
        Sweet sweet;
        public Pearl(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("¥D®Æ") >= 0)
                    return sweet.Description.Replace("¥D®Æ", "¬Ã¯]");
                if (sweet.Description.IndexOf("+¬Ã¯]") >= 0)
                    return sweet.Description.Replace("+¬Ã¯]", "++¬Ã¯]");
                return sweet.Description + " +¬Ã¯]";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

