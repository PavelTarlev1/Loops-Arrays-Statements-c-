using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication110
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
        start:
            int number = int.Parse(Console.ReadLine());
            var arr = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            if (arr[0] + arr[2] == arr[1])
            {
                result = result + number;
                goto start;
            }
            if (arr[0] + arr[2] != arr[1])
            {
                Console.WriteLine(result);
            }
        }
    }
}
