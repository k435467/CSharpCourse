using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz7;
using _104_Classwork5;

namespace _106_Quiz6
{
    class Pyramid:Shape3D
    {
        new private static int _amount;  //隱藏繼承
        private double _side;
        private double _height;
        public static Cylinder Create(double side, double height, ShapeType.Material mType)
        {
            if (side <= 0)
                throw new NegativeException( "邊長不可小於或等於零!" );
            else if (height <= 0)
                throw new NegativeException("高度不可小於或等於零!");
            else
                return new Cylinder(side, height, mType);
        }
        public Pyramid():base()
        {
            _geoType = ShapeType.Geo.PYRAMID;
            _side = 0;
            _height = 0;
            _amount++;
        }
        public Pyramid(double side, double height, ShapeType.Material mType):base(mType)
        {
            _geoType = ShapeType.Geo.PYRAMID;
            Side = side;
            Height = height;
            _amount++;
        }
       new public static int Amount   //隱藏繼承
        {
            get { return _amount; }
        }
        public double Side
        {
            get { return _side; }
            set
            {
                if (value < 0)
                    _side = 0;
                else
                    _side = value;
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                    _height = 0;
                else
                    _height = value;
            }
        }
        public override double Volume()                //改寫父類別的方法, 給其他類別使用故宣告為 public
        {
            return 1.0/3*_side*_side*_height;
        }

        public override string ShapeProperty()         //改寫父類別的方法, 給其他類別使用故宣告為 public
        {
            string str = string.Format("{0,8}", "Pyramid");
            str += '\t';
            str += string.Format("{0,8:F2}", _side);
            str += '\t';
            str += string.Format("{0,8:F2}", _height);
            str += '\t';
            str += Property();                         //重構, 降低重複的程式碼
            return str;

        }
    }
}
