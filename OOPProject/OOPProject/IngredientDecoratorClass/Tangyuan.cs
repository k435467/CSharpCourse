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
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "�p����");
                if (sweet.Description.IndexOf("+�p����") >= 0)
                    return sweet.Description.Replace("+�p����", "++�p����");
                return sweet.Description + " +�p����";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

