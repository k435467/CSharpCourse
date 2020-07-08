using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class Honeydew: IngredientDecorator
    {
        Sweet sweet;
        public Honeydew(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "�e�a��");
                if (sweet.Description.IndexOf("+�e�a��") >= 0)
                    return sweet.Description.Replace("+�e�a��", "++�e�a��");
                return sweet.Description + " +�e�a��";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

