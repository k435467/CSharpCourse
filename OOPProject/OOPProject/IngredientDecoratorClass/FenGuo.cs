using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class FenGuo: IngredientDecorator
    {
        Sweet sweet;
        public FenGuo(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "���_");
                if (sweet.Description.IndexOf("+���_") >= 0)
                    return sweet.Description.Replace("+���_", "++���_");
                return sweet.Description + " +���_";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

