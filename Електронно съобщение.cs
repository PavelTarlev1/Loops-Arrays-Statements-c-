using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication156
{
    class Program
    {
        static void Main(string[] args)
        {
            string Letter = Console.ReadLine();
            int counter = 0;
            int result = 0;
            foreach (var i in Letter)
            {
                if (!(i >= 'A' && i <= 'Z') && !(i >= 'a' && i <= 'z') && !(i >= '0' && i <= '9') && i != ' ' && i != '.')
                {
                    counter++;
                    if (counter > result)
                    {
                        result = counter;
                    }
                }
                else
                {
                    counter = 0;
                }

            }
            Console.WriteLine(result);
            
        }
    }
}
