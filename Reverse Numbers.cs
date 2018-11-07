using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication79
{
    class Program
    {
        static void Main(string[] args)
        {
            string Number = Console.ReadLine();
            char[] numberList = Number.ToCharArray();
            Array.Reverse(numberList);
            for (int i = 0; i < Number.Length; i++)
            {
                Console.Write(numberList[i]);                
            }
        }
    }
}
