using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class Taro: IngredientDecorator
    {
        Sweet sweet;
        public Taro(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "�e���Y");
                if (sweet.Description.IndexOf("+�e���Y") >= 0)
                    return sweet.Description.Replace("+�e���Y", "++�e���Y");
                return sweet.Description + " +�e���Y";
}}
        public override int Cost()
        {return 20 + sweet.Cost();}
}}

