using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            while (true)
            {
                Console.WriteLine("請輸入三角形的三個頂點座標，並計算其特性");
                Console.WriteLine("(x1, y1) = ");
                t.x1 = double.Parse(Console.ReadLine());
                t.y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("(x2, y2) = ");
                t.x2 = double.Parse(Console.ReadLine());
                t.y2 = double.Parse(Console.ReadLine());
                Console.WriteLine("(x3, y3) = ");
                t.x3 = double.Parse(Console.ReadLine());
                t.y3 = double.Parse(Console.ReadLine());
                t.GetLen();

                if ( !t.isValid() )
                {
                    Console.WriteLine("這三點不能組成三角形!");
                }
                else
                {
                    Console.WriteLine("Perimeter = {0}", t.Perimeter());
                    Console.WriteLine("Area = {0}", t.Area());
                    Console.WriteLine("Radius of Circumcircle = {0}", t.RadiusOfCircumcircle());
                    if (t.isRight())
                        Console.WriteLine("直角三角形!");
                    else
                        Console.WriteLine("非直角三角形!");
                }

                Console.WriteLine("Again?");
                string yORn = Console.ReadLine();
                if (yORn != "y")
                    break;
            }
        }
    }

    class Triangle
    {
        public double x1, y1, x2, y2, x3, y3;
        public double[] l = new double[3];

        public void GetLen()
        {
            this.l[0] = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            this.l[1] = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            this.l[2] = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            Array.Sort(this.l);
        }
        public bool isValid()
        {
            return (this.l[0] + this.l[1] > this.l[2]);
        }
        public double Perimeter()
        {
            return (this.l[0] + this.l[1] + this.l[2]);
        }
        public double Area()
        {
            double p = this.Perimeter() / 2;
            return Math.Sqrt(p * (p - this.l[0]) * (p - this.l[1]) * (p - this.l[2]));
        }
        public double RadiusOfCircumcircle()
        {
            return (this.l[0] * this.l[1] * this.l[2]) / (4 * this.Area());
        }
        public bool isRight()
        {
            return (Math.Pow(this.l[0], 2) + Math.Pow(this.l[1], 2) == Math.Pow(this.l[2], 2));
        }
    }
}
