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
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "���");
                if (sweet.Description.IndexOf("+���") >= 0)
                    return sweet.Description.Replace("+���", "++���");
                return sweet.Description + " +���";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

