using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class GreenBean: IngredientDecorator
    {
        Sweet sweet;
        public GreenBean(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("¥D®Æ") >= 0)
                    return sweet.Description.Replace("¥D®Æ", "ºñ¨§");
                if (sweet.Description.IndexOf("+ºñ¨§") >= 0)
                    return sweet.Description.Replace("+ºñ¨§", "++ºñ¨§");
                return sweet.Description + " +ºñ¨§";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

