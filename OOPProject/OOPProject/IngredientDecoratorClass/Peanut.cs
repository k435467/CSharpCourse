using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class Peanut: IngredientDecorator
    {
        Sweet sweet;
        public Peanut(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("主料") >= 0)
                    return sweet.Description.Replace("主料", "花生");
                if (sweet.Description.IndexOf("+花生") >= 0)
                    return sweet.Description.Replace("+花生", "++花生");
                return sweet.Description + " +花生";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

