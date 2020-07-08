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
                if (sweet.Description.IndexOf("主料") >= 0)
                    return sweet.Description.Replace("主料", "芋地瓜圓");
                if (sweet.Description.IndexOf("+芋地瓜圓") >= 0)
                    return sweet.Description.Replace("+芋地瓜圓", "++芋地瓜圓");
                return sweet.Description + " +芋地瓜圓";
}}
        public override int Cost()
        {return 10 + sweet.Cost();}
}}

