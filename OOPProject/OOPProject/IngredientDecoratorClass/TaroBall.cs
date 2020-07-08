using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class TaroBall: IngredientDecorator
    {
        Sweet sweet;
        public TaroBall(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "���a�ʶ�");
                if (sweet.Description.IndexOf("+���a�ʶ�") >= 0)
                    return sweet.Description.Replace("+���a�ʶ�", "++���a�ʶ�");
                return sweet.Description + " +���a�ʶ�";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

