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
                if (sweet.Description.IndexOf("¥D®Æ") >= 0)
                    return sweet.Description.Replace("¥D®Æ", "±m­i¤p´ö¶ê");
                if (sweet.Description.IndexOf("+±m­i¤p´ö¶ê") >= 0)
                    return sweet.Description.Replace("+±m­i¤p´ö¶ê", "++±m­i¤p´ö¶ê");
                return sweet.Description + " +±m­i¤p´ö¶ê";
}}
        public override int Cost()
        {return 20 + sweet.Cost();}
}}

