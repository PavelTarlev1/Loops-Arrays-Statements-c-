using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication164
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = "";
            int counter = 0;
            for (int i = 1; i < number + 1; i++)
            {
                bool IsPrime = true;
                for (int p = 2; p < i; p++)
                {
                    if (i % p == 0)
                    {
                        IsPrime = false;
                    }
                }
                if (IsPrime == true)
                {
                    result += "1";
                    counter++;
                    Console.WriteLine(result);
                }
                if (IsPrime == false)
                {
                    result += "0";
                }
            }
        }
    }
}

