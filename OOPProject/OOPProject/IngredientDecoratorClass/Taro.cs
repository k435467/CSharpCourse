using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class Taro: IngredientDecorator
    {
        Sweet sweet;
        public Taro(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("主料") >= 0)
                    return sweet.Description.Replace("主料", "蜜芋頭");
                if (sweet.Description.IndexOf("+蜜芋頭") >= 0)
                    return sweet.Description.Replace("+蜜芋頭", "++蜜芋頭");
                return sweet.Description + " +蜜芋頭";
}}
        public override int Cost()
        {return 20 + sweet.Cost();}
}}

