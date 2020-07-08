using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class RedBean: IngredientDecorator
    {
        Sweet sweet;
        public RedBean(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("¥D®Æ") >= 0)
                    return sweet.Description.Replace("¥D®Æ", "¬õ¨§");
                if (sweet.Description.IndexOf("+¬õ¨§") >= 0)
                    return sweet.Description.Replace("+¬õ¨§", "++¬õ¨§");
                return sweet.Description + " +¬õ¨§";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

