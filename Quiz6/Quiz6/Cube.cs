using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Cube
    {
        private static int amount = 0;
        private double side;
        private double density;

        public Cube()
        {
            side = 0;
            density = 0;
            amount++;
        }
        public Cube(double side, double density)
        {
            this.Side = side;
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
            return side * side * side;
        }
        public double Weight()
        {
            return this.Vol() * density;
        }
        public string Info()
        {
            string str = "";
            str += string.Format("{0,8}", "Cube");
            str += "\t";
            str += string.Format("{0,8:F2}", side);
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
