using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class Tangyuan: IngredientDecorator
    {
        Sweet sweet;
        public Tangyuan(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("主料") >= 0)
                    return sweet.Description.Replace("主料", "小湯圓");
                if (sweet.Description.IndexOf("+小湯圓") >= 0)
                    return sweet.Description.Replace("+小湯圓", "++小湯圓");
                return sweet.Description + " +小湯圓";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

