using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication179
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] z = x.Split(' ');
            int FirstNumber = int.Parse(z[0]);
            int SecondNumber = int.Parse(z[1]);
            int SmallerNumber = Math.Min(FirstNumber, SecondNumber);
            bool IFnone = true;
            
            for (int i = 2; i <= SmallerNumber; i++)
            {
                if (FirstNumber % i == 0 && SecondNumber % i == 0)
                {
                    bool IFPrime = true;
                    for (int y = 2; y < i; y++)
                    {
                        if (i % y ==0)
                        {
                            IFPrime = false;
                        }
                    }
                    if (IFPrime == true)
                    {
                        Console.Write("{0} ",i);
                        IFnone = false;
                    }
                }
            }
            if (IFnone == true)
            {
                Console.WriteLine("-1");
            }

        }
    }
}
