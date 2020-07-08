using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class RanbowTangyan: IngredientDecorator
    {
        Sweet sweet;
        public RanbowTangyan(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "�m�i�p����");
                if (sweet.Description.IndexOf("+�m�i�p����") >= 0)
                    return sweet.Description.Replace("+�m�i�p����", "++�m�i�p����");
                return sweet.Description + " +�m�i�p����";
}}
        public override int Cost()
        {return 20 + sweet.Cost();}
}}

