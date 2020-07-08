using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    class Triangle
    {
        public double[] x = new double[3];
        public double[] y = new double[3];

        private void GetLens(double[] l)
        {
            l[0] = Math.Sqrt(Math.Pow(this.x[0] - this.x[1], 2) + Math.Pow(this.y[0] - this.y[1], 2));
            l[1] = Math.Sqrt(Math.Pow(this.x[1] - this.x[2], 2) + Math.Pow(this.y[1] - this.y[2], 2));
            l[2] = Math.Sqrt(Math.Pow(this.x[0] - this.x[2], 2) + Math.Pow(this.y[0] - this.y[2], 2));
            Array.Sort(l);
        }
        public bool IsValid()
        {
            double[] l = new double[3];
            this.GetLens(l);
            return (l[0] + l[1] > l[2]);
        }
        public double Perimeter()
        {
            double[] l = new double[3];
            this.GetLens(l);
            return (l[0] + l[1] + l[2]);
        }
        public double Area()
        {
            double p = this.Perimeter() / 2;
            double[] l = new double[3];
            this.GetLens(l);
            return Math.Sqrt(p * (p - l[0]) * (p - l[1]) * (p - l[2]));
        }
        public double RadiusOfCircumcircle()
        {
            double[] l = new double[3];
            this.GetLens(l);
            return (l[0] * l[1] * l[2]) / (4 * this.Area());
        }
        public bool IsRight()
        {
            double[] l = new double[3];
            this.GetLens(l);
            return (Math.Pow(l[0], 2) + Math.Pow(l[1], 2) == Math.Pow(l[2], 2));
        }
    }
}
