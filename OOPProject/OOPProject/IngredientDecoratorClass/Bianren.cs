using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPProject
{
    class Bianren: IngredientDecorator
    {
        Sweet sweet;
        public Bianren(Sweet sweet)
        {this.sweet = sweet;}
        public override string Description
        {
            get
            {
                if (sweet.Description.IndexOf("₯D®Ζ") >= 0)
                    return sweet.Description.Replace("₯D®Ζ", "νυ€―");
                if (sweet.Description.IndexOf("+νυ€―") >= 0)
                    return sweet.Description.Replace("+νυ€―", "++νυ€―");
                return sweet.Description + " +νυ€―";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

