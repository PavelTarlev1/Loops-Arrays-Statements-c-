using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            long N = long.Parse(Console.ReadLine());
            double[] arr = new double[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            double min = arr.Min();
            Console.WriteLine("min={0:0.00##}", min);
            double max = arr.Max();
            Console.WriteLine("max={0:0.00##}", max);
            double sum = arr.Sum();
            Console.WriteLine("sum={0:0.00##}", sum);
            double avg = arr.Average();
            avg = System.Math.Round(avg, 2);
            Console.WriteLine("avg={0:0.00##}", avg);

        }
    }
}
