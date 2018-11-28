using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication176
{
    class Program
    {
        static void Main(string[] args)
        {
            string world = Console.ReadLine();
            int counter  = 0;
            foreach (var s in world)
            {
                if (s=='a' || s == 'e'|| s=='i' || s == 'o'|| s== 'u' || s == 'y')
                {
                    counter++; 
                }

            }
            if (!(counter == 2))
            {
                Console.WriteLine("{0} {1}",counter , (4-counter));
            }
            if (counter == 2)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
