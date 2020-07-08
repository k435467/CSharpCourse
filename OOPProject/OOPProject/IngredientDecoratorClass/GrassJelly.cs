using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class GrassJelly: IngredientDecorator
    {
        Sweet sweet;
        public GrassJelly(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("¥D®Æ") >= 0)
                    return sweet.Description.Replace("¥D®Æ", "¥P¯ó");
                if (sweet.Description.IndexOf("+¥P¯ó") >= 0)
                    return sweet.Description.Replace("+¥P¯ó", "++¥P¯ó");
                return sweet.Description + " +¥P¯ó";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

