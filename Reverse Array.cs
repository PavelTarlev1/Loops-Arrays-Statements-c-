using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication94
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i]+", ");
            }
            Console.Write(arr[arr.Length-1]);
       
        }
    }
}
