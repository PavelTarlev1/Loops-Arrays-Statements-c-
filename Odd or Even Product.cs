using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication171
{
    class Program
    {
        static void Main(string[] args)
        {
            int HLArr = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long odd = 1,
                even = 1;

            for (int i = 0; i < HLArr; i++)
            {
                if (i == 0)
                {
                    odd *= arr[i];
                    continue;
                }
                if (i % 2 != 0)
                {
                    even *= arr[i];
                    continue;
                }
                if (i % 2 == 0)
                {
                    odd *= arr[i];
                    continue;
                }
                
            }
            if (odd == even)
            {
                Console.WriteLine("yes {0}",odd);
            }
            if (odd != even)
            {
                Console.WriteLine("no {0} {1}",odd , even);
            }
        }
    }
}
