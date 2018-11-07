using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {
            int howLongArrey = int.Parse(Console.ReadLine());
            int[] arr = new int[howLongArrey];
            int howMany = int.Parse(Console.ReadLine());
            for (int i = 0; i < howLongArrey; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            int summ = 0;
            for (int p = 0; p < howMany; p++)
            {
                summ = summ + arr[p];
            }
            Console.WriteLine(summ);
        }
    }
}
