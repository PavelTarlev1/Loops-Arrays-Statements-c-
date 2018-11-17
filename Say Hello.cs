using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numbers = int.Parse(Console.ReadLine());
            int bufferNumber = 0;
            for (int i = 0; i < Numbers; i++)
            {

                Console.WriteLine(bufferNumber);
                bufferNumber = bufferNumber + 5;
            }
        }
    }
}
