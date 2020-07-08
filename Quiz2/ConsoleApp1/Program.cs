using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數n:");
            string strN, strK;
            int n = 0, total = 0, k = 0, curK = 0;
            strN = Console.ReadLine();
            Console.WriteLine("請輸入一個整數k:");
            strK = Console.ReadLine();
            n = int.Parse(strN);
            k = int.Parse(strK);

            for (int i=1; i<n; i++)
            {
                //Console.WriteLine("i = {0}\n", i);
                int tmpI = i, part = 0, sum = 0;
                do
                {
                    part = tmpI % 100;
                    tmpI /= 100;
                    sum += (part * part * part);
                } while (tmpI != 0);

                if (sum == i && curK < k)
                {
                    total += sum;
                    curK++;
                    Console.WriteLine("{0}", i);
                }
            }

            Console.WriteLine("total = {0}\n", total);
            Console.ReadKey();
        }
    }
}
