using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class GreenPapaya: IngredientDecorator
    {
        Sweet sweet;
        public GreenPapaya(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("�D��") >= 0)
                    return sweet.Description.Replace("�D��", "�C���");
                if (sweet.Description.IndexOf("+�C���") >= 0)
                    return sweet.Description.Replace("+�C���", "++�C���");
                return sweet.Description + " +�C���";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

