using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
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
                t.x[0] = double.Parse(Console.ReadLine());
                t.y[0] = double.Parse(Console.ReadLine());
                Console.WriteLine("(x2, y2) = ");
                t.x[1] = double.Parse(Console.ReadLine());
                t.y[1] = double.Parse(Console.ReadLine());
                Console.WriteLine("(x3, y3) = ");
                t.x[2] = double.Parse(Console.ReadLine());
                t.y[2] = double.Parse(Console.ReadLine());

                if (!t.IsValid())
                {
                    Console.WriteLine("這三點不能組成三角形!");
                }
                else
                {
                    Console.WriteLine("Perimeter = {0}", t.Perimeter());
                    Console.WriteLine("Area = {0}", t.Area());
                    Console.WriteLine("Radius of Circumcircle = {0}", t.RadiusOfCircumcircle());
                    if (t.IsRight())
                        Console.WriteLine("直角三角形!");
                    else
                        Console.WriteLine("非直角三角形!");
                }

                Console.WriteLine("Again?");
                string yORn = Console.ReadLine();
                if (yORn != "y")
                    break;
            }
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
