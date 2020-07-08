using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz7;
using _106_Quiz6;

namespace _104_Classwork5
{
    public class ShapeFactory
    {
        public static Shape3D Create(string name, ShapeType.Material mType, double arg1, double arg2)
        {
            Shape3D rv = null;
            switch (name)
            {
                case "球":
                    rv = Ball.Create(arg1, mType);
                    return rv;
                case "立方體":
                    rv = Cube.Create(arg1, mType);
                    return rv;
                case "圓柱體":
                    rv = Cylinder.Create(arg1, arg2, mType);
                    return rv;
                case "金字塔":
                    rv = Pyramid.Create(arg1, arg2, mType);
                    return rv;
                default:
                    return rv;
            }
        }
    }
}
