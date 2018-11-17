using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication135
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= number; i++)
            {
                for (int p = 1; p <= i; p++)
                {
                    result +=p + " ";
                }
                Console.WriteLine(result);
                result = "";
            }
            for (int i = number-1; i >= 1; i--)
            {
                for (int p = 1; p <= i; p++)
                {
                    result += p + " ";
                }
                Console.WriteLine(result);
                result = "";
            }
            
        }
    }
}
