using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Pyramid
    {
        private static int amount = 0;
        private double side;
        private double tall;
        private double density;

        public Pyramid()
        {
            side = 0;
            density = 0;
            amount++;
        }
        public Pyramid(double side, double tall, double density)
        {
            this.Side = side;
            this.Tall = tall;
            this.Density = density;
            amount++;
        }
        public static int Amount
        {
            get { return amount; }
        }
        public double Side
        {
            get { return side; }
            set
            {
                if (value < 0)
                    side = 0;
                else
                    side = value;
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
            return (1.0 / 3.0) * side * side * tall;
        }
        public double Weight()
        {
            return this.Vol() * density;
        }
        public string Info()
        {
            string str = "";
            str += string.Format("{0,8}", "Pyramid");
            str += "\t";
            str += string.Format("{0,8:F2}", side);
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
