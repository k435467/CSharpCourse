using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class GrassJelly: IngredientDecorator
    {
        Sweet sweet;
        public GrassJelly(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "�P��");
                if (sweet.Description.IndexOf("+�P��") >= 0)
                    return sweet.Description.Replace("+�P��", "++�P��");
                return sweet.Description + " +�P��";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

