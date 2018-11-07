using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication108
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] items = new double[3];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = Convert.ToDouble(Console.ReadLine());
            }
            double max = 0;
            max = items.Max();
            Console.WriteLine(max);
        }
    }
}
