using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz6;

namespace _106_Quiz6
{
    class Ball: Shape3D
    {
        new private static int _amount;
        //private double _density;
        private double _radius;
        private static double _pi=3.1415926;  //可以使用 readonly 來修飾
        public Ball(): base()
        {
            _radius = 0;
            //_density = 0;
            _amount++;
        }

        public Ball(double radius, double density): base(density)
        {
            //Density = density;
            Radius = radius;
            _amount++;
        }
        new public static int Amount
        {
            get { return _amount; }
        }
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                    _radius = 0;
                else
                    _radius = value;
            }
        }
        //public double Density
        //{
        //    get { return _density; }
        //    set
        //    {
        //        if (value < 0)
        //            _density = 0;
        //        else
        //            _density = value;
        //    }
        //}
        public override double Volume()
        {
            return 4.0/3*_pi*_radius*_radius*_radius;
        }
        //public double Weight()
        //{
        //    return _density * Volume();
        //}

        public override string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Ball");
            str += '\t';
            str += string.Format("{0,8:F2}", _radius);
            str += '\t';
            str += string.Format("{0,8}", "");
            str += '\t';
            //str += string.Format("{0,8:F2}", _density);
            //str += '\t';
            //str += string.Format("{0,8:F2}", Volume());
            //str += '\t';
            //str += string.Format("{0,8:F2}", Weight());
            str += Property();
            return str;
        }
    }
}
