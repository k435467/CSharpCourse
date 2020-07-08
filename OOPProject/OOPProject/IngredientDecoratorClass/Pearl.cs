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
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "�ï]");
                if (sweet.Description.IndexOf("+�ï]") >= 0)
                    return sweet.Description.Replace("+�ï]", "++�ï]");
                return sweet.Description + " +�ï]";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

