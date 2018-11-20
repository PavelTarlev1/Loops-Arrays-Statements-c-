using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double result = 1;
            long ifac = 1;
            for (int i = 1; i <= n; i++)
            {
                ifac = 1;
                for (int j = i; j >= 1; j--)
                {
                    ifac *= j;
                }
                result += ifac / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}", result);

        }
    }
}
