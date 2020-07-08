using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    public static class FoodType
    {
        public enum SweetType
        {
            Douhua=0, ShavedIce
        };
        public enum MainIngredientType
        {
            Peanut=0, RedBean, Bianren, GreenBean, TaroBall, FenGuo, RanbowTangyan
        };
        public enum SideIngredientType
        {
            RedBean=0, Peanut, GreenBean, Bianren, Pearl, TaroBall, Tangyuan, GrassJelly, GreenPapaya, Honeydew, CondensedMilk, FenGuo, Taro, RanbowTangyan
        };
        public enum TemperatureType
        {
            Iced=0, Warm
        };
    }

    public static class SweetFactory
    {
        public static Sweet CreateSweet(FoodType.SweetType sweetType,
                                        FoodType.TemperatureType tempType,
                                        FoodType.MainIngredientType mainIngredientType,
                                        List<FoodType.SideIngredientType> sideIngredientList)
        {
            // sweet type
            Sweet sweet = null;
            if (sweetType == FoodType.SweetType.Douhua)
                sweet = new Douhua();
            else
                sweet = new ShavedIce();

            // temperature type
            if (tempType == FoodType.TemperatureType.Iced)
                sweet = new Iced(sweet);
            else
                sweet = new Warm(sweet);

            // main ingredient type
            switch(mainIngredientType)
            {
                case FoodType.MainIngredientType.Bianren:
                    sweet = new Bianren(sweet);
                    break;
                case FoodType.MainIngredientType.FenGuo:
                    sweet = new FenGuo(sweet);
                    break;
                case FoodType.MainIngredientType.GreenBean:
                    sweet = new GreenBean(sweet);
                    break;
                case FoodType.MainIngredientType.Peanut:
                    sweet = new Peanut(sweet);
                    break;
                case FoodType.MainIngredientType.RanbowTangyan:
                    sweet = new RanbowTangyan(sweet);
                    break;
                case FoodType.MainIngredientType.RedBean:
                    sweet = new RedBean(sweet);
                    break;
                case FoodType.MainIngredientType.TaroBall:
                    sweet = new TaroBall(sweet);
                    break;
            }

            // side ingredient type
            
            foreach(var sideIngredient in sideIngredientList)
            {
                switch(sideIngredient)
                {
                    case FoodType.SideIngredientType.Bianren:
                        sweet = new Bianren(sweet);
                        break;
                    case FoodType.SideIngredientType.CondensedMilk:
                        sweet = new CondensedMilk(sweet);
                        break;
                    case FoodType.SideIngredientType.FenGuo:
                        sweet = new FenGuo(sweet);
                        break;
                    case FoodType.SideIngredientType.GrassJelly:
                        sweet = new GrassJelly(sweet);
                        break;
                    case FoodType.SideIngredientType.GreenBean:
                        sweet = new GreenBean(sweet);
                        break;
                    case FoodType.SideIngredientType.GreenPapaya:
                        sweet = new GreenPapaya(sweet);
                        break;
                    case FoodType.SideIngredientType.Honeydew:
                        sweet = new Honeydew(sweet);
                        break;
                    case FoodType.SideIngredientType.Peanut:
                        sweet = new Peanut(sweet);
                        break;
                    case FoodType.SideIngredientType.Pearl:
                        sweet = new Pearl(sweet);
                        break;
                    case FoodType.SideIngredientType.RanbowTangyan:
                        sweet = new RanbowTangyan(sweet);
                        break;
                    case FoodType.SideIngredientType.RedBean:
                        sweet = new RedBean(sweet);
                        break;
                    case FoodType.SideIngredientType.Tangyuan:
                        sweet = new Tangyuan(sweet);
                        break;
                    case FoodType.SideIngredientType.Taro:
                        sweet = new Taro(sweet);
                        break;
                    case FoodType.SideIngredientType.TaroBall:
                        sweet = new TaroBall(sweet);
                        break;
                }
            }

            return sweet;
        }
    }
}
