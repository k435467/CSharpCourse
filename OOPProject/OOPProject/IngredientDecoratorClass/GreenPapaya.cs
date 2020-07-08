using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class GreenPapaya: IngredientDecorator
    {
        Sweet sweet;
        public GreenPapaya(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("¥D®Æ") >= 0)
                    return sweet.Description.Replace("¥D®Æ", "«C¤ì¥Ê");
                if (sweet.Description.IndexOf("+«C¤ì¥Ê") >= 0)
                    return sweet.Description.Replace("+«C¤ì¥Ê", "++«C¤ì¥Ê");
                return sweet.Description + " +«C¤ì¥Ê";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

