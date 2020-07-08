using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Ball
    {
        private static int amount = 0;
        private double radius;
        private double density;

        public Ball()
        {
            radius = 0;
            density = 0;
            amount++;
        }
        public Ball(double radius, double density)
        {
            this.Radius = radius;
            this.Density = density;
            amount++;
        }
        public static int Amount
        {
            get { return amount; }
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                    radius = 0;
                else
                    radius = value;
            }
        }
        public double Density
        {
            get { return density; }
            set
            {
                if (value < 0)
                    density = 0;
                else
                    density = value;
            }
        }
        public double Vol()
        {
            return (4.0/3.0) * Math.PI * radius * radius * radius;
        }
        public double Weight()
        {
            return this.Vol() * density;
        }
        public string Info()
        {
            string str = "";
            str += string.Format("{0,8}", "Ball");
            str += "\t";
            str += string.Format("{0,8:F2}", radius);
            str += "\t";
            str += string.Format("{0,8}", "");
            str += "\t";
            str += string.Format("{0,8:F2}", this.Vol());
            str += "\t";
            str += string.Format("{0,8:F2}", this.Weight());
            str += "\n";
            return str;
        }
    }
}
