using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication149
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            var arr = Number.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]!=0)
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }

        }
    }
}
