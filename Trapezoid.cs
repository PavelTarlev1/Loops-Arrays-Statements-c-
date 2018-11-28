using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication182
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            Console.Write(new string ('.',Number));
            Console.WriteLine(new string('*',Number));
            for (int i = 1; i < Number; i++)
            {
                Console.Write(new string('.',Number-i));
                Console.Write("*");
                Console.Write(new string('.',(Number-2)+i));
                Console.WriteLine('*');
            }
            Console.WriteLine(new string('*',Number*2));
        }
    }
}
