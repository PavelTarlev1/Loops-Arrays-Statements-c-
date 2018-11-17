using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication137
{
    class Program
    {
        static void Main(string[] args)
        {
            int Arrlenght = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] < arr[i + 1] && arr[i + 1] > arr[i + 2])
                {
                    result = i + 1;
                    Console.WriteLine(result);
                    break;


                }

            }
            if (result == 0)
            {
                Console.WriteLine("-1");
            }
        }

    }
}
