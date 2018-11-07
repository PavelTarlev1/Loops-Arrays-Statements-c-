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
            int chekNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < HowlongArr; i++)

            {
                if(arr[i] == chekNumber)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
   
        }
    }
}
