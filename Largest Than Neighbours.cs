using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication80
{
    class Program
    {
        static void Main(string[] args)
        {
            int HowlongArr = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 0; i < HowlongArr - 2; i++)
            {
                if (arr[i] < arr[i + 1] && arr[i + 1] > arr[i + 2])
                {
                    counter++;

                }
            }
            Console.WriteLine(counter);
        }
    }
}
