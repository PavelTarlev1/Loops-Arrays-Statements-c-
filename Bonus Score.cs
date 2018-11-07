using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication86
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            int Result = 0;
            if (Number>=1 && Number<=3)
            {
                Result = Number * 10;
                Console.WriteLine(Result);
               
            }
            if (Number >= 4 && Number <= 6)
            {
                Result = Number * 100;
                Console.WriteLine(Result); 
            }
            if (Number >= 7 && Number <= 9)
            {
                Result = Number * 1000;
                Console.WriteLine(Result);
            }
            if (Number <0 || Number>9 || Number==0)
            {
                Console.WriteLine("invalid score");
            }
        }
        
    }
}
