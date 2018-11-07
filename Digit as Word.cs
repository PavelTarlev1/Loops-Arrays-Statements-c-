using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication89
{
    class Program
    {
        static void Main(string[] args)
        {
            string EnterNumber = Console.ReadLine();
            bool YesNo = EnterNumber.All(char.IsDigit);
            if (YesNo == false)
            {
                Console.WriteLine("not a digit");
            }
            if (YesNo == true)
            {
                int Number = int.Parse(EnterNumber);
                if(Number == 0)
                {
                    Console.WriteLine("zero");
                }
                if (Number == 1)
                {
                    Console.WriteLine("one");
                }
                if (Number == 2)
                {
                    Console.WriteLine("two");
                }
                if (Number == 3)
                {
                    Console.WriteLine("three");
                }
                if (Number == 4)
                {
                    Console.WriteLine("four");
                }
                if (Number == 5)
                {
                    Console.WriteLine("five");
                }
                if (Number == 6)
                {
                    Console.WriteLine("six");
                }
                if (Number == 7)
                {
                    Console.WriteLine("seven");
                }
                if (Number == 8)
                {
                    Console.WriteLine("eight");
                }
                if (Number == 9)
                {
                    Console.WriteLine("nine");
                }
            }

        }
    }
}
