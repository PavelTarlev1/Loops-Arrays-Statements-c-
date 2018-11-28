using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication178
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int Words = 1;
            int digits = 1;
            foreach (char c in word)
            {
                if (c >= 'A' && c <='Z')
                {
                    Words += (System.Convert.ToSByte(c));
                    
                }
                if (c >= '0' && c <='9')
                {
                    digits *= int.Parse(c.ToString());

                }  
            }
            Words /= 10;
            if(digits != Words)
            {
                Console.WriteLine("No");
            }
            if(digits == Words)
            {
                Console.WriteLine("Yes {0}",Words);
            }
        }
    }
}
