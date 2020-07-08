using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz6;

namespace _106_Quiz6
{
    class Shape3D
    {
        protected static int _amount;
        protected double _density;

        public Shape3D()
        {
            _amount++;
            _density = 0;
        }
        public Shape3D(double density)
        {
            _amount++;
            Density = density;
        }

        public static int Amount
        {
            get { return _amount; }
        }
        public double Density
        {
            get { return _density; }
            set
            {
                if (value < 0)
                    _density = 0;
                else
                    _density = value;
            }
        }

        public virtual double Volume()
        {
            return 0;
        }
        public double Weight()
        {
            return Density * Volume();
        }

        public virtual string ShapeProperty()
        {
            return "";
        }
        public string Property()
        {
            string str = "";
            str += string.Format("{0,8:F2}", Density);
            str += '\t';
            str += string.Format("{0,8:F2}", Volume());
            str += '\t';
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }
        
    }
}