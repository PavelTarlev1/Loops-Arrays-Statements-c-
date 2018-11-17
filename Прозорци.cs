using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication151
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumberPrice = Console.ReadLine();
            string [] y = NumberPrice.Split(' ');
            int Number = int.Parse(y[0]);
            int Prise = int.Parse(y[1]);
            int result = 0;
            for (int i = 0; i < Number; i++)
            {
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (arr[2] == 1)
                {
                    result += (arr[0] * arr[1]);
                }
            }
            Console.WriteLine(result*Prise);
        }
    }
}
