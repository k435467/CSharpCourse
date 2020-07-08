using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Cylinder
    {
        private static int amount = 0;
        private double radius;
        private double tall;
        private double density;

        public Cylinder()
        {
            radius = 0;
            tall = 0;
            density = 0;
            amount++;
        }
        public Cylinder(double radius, double tall, double density)
        {
            this.Radius = radius;
            this.Tall = tall;
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
        public double Tall
        {
            get { return tall; }
            set
            {
                if (value < 0)
                    tall = 0;
                else
                    tall = value;
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
            return Math.PI * radius * radius * tall;
        }
        public double Weight()
        {
            return this.Vol() * density;
        }
        public string Info()
        {
            string str = "";
            str += string.Format("{0,8}", "Cylinder");
            str += "\t";
            str += string.Format("{0,8:F2}", radius);
            str += "\t";
            str += string.Format("{0,8}", tall);
            str += "\t";
            str += string.Format("{0,8:F2}", this.Vol());
            str += "\t";
            str += string.Format("{0,8:F2}", this.Weight());
            str += "\n";
            return str;
        }
    }
}
