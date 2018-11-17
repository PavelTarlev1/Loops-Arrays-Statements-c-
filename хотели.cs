using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication150
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberofHottels = int.Parse(Console.ReadLine());
            int [] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int counterback = 0;
            int temphight = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (temphight < arr[i])
                {
                    temphight = arr[i];
                    counter++;
                }
            }
            temphight = 0;
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (temphight < arr[i])
                {
                    temphight = arr[i];
                    counterback++;
                }
            }
            Console.WriteLine("{0} {1}",counter, counterback);
            

        }
    }
}
