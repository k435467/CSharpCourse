using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class CondensedMilk: IngredientDecorator
    {
        Sweet sweet;
        public CondensedMilk(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "�Ҩ�");
                if (sweet.Description.IndexOf("+�Ҩ�") >= 0)
                    return sweet.Description.Replace("+�Ҩ�", "++�Ҩ�");
                return sweet.Description + " +�Ҩ�";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

