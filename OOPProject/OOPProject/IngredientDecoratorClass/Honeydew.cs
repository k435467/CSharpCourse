using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class Honeydew: IngredientDecorator
    {
        Sweet sweet;
        public Honeydew(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("主料") >= 0)
                    return sweet.Description.Replace("主料", "蜜地瓜");
                if (sweet.Description.IndexOf("+蜜地瓜") >= 0)
                    return sweet.Description.Replace("+蜜地瓜", "++蜜地瓜");
                return sweet.Description + " +蜜地瓜";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

