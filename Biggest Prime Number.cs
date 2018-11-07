using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication119
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            for (int i = 1; i < Number; Number--)
            {
                bool IFprime = true;
                for (int p = 2; p < Number; p++)
                {
                    if(Number % p == 0)
                    {
                        IFprime = false;
                        break;
                    }
                }
                if (IFprime == true)
                {
                    Console.WriteLine(Number);
                    break;
                }
            }
        }
    }
}
