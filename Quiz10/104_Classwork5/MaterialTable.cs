using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz7;
namespace _106_Classwork8
{
    public class Element
    {
        public ShapeType.Material MaterialType { get; set; }
        public string Name { get; set; }
        public double Density { get; set; }

        public Element() { }
        public Element(ShapeType.Material mType, string name, double density)
        {
            MaterialType = mType;
            Name = name;
            Density = density;
        }
    }

    public static class MaterialTable      // 宣告 static 類別, 不用 new Obj 即可使用
    {
        public static Element[] elements= { new Element(ShapeType.Material.Al, "鋁", 2.7),
                                            new Element(ShapeType.Material.Fe, "鐵", 7.87),
                                            new Element(ShapeType.Material.Pb, "鉛", 11.3)
                                           };
        public  static ShapeType.Material Type(string name)
        {
            foreach (var e in elements)
            {
                if (e.Name == name)
                    return e.MaterialType;
            }
            return ShapeType.Material.UNKNOWN;
        }
        public static double Density(string name)
        {
            foreach(var e in elements)
            {
                if (e.Name == name)
                    return e.Density;
            }
            return 0;
        }
        public static double Density(ShapeType.Material mType)
        {
            foreach (var e in elements)
            {
                if (e.MaterialType == mType)
                    return e.Density;
            }
            return 0;
        }
        public static string Name(ShapeType.Material mType)
        {
            foreach (var e in elements)
            {
                if (e.MaterialType == mType)
                    return e.Name;
            }
            return "未知";
        }
    }
       
}
