using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication85
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Number1 = double.Parse(Console.ReadLine());
            Double Number2 = double.Parse(Console.ReadLine());

            if (Number1 < Number2)
            {
                Console.WriteLine("{0} {1}",Number1 ,Number2); 
            }
            if (Number1 > Number2)
            {
                Console.WriteLine("{0} {1}",Number2, Number1);
               
            }
            if (Number1 == Number2)
                Console.WriteLine("{0} {1}", Number2, Number1);
        }
    }
}
