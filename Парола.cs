using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = Console.ReadLine();                
            string [] y = x.Split(' ');             
            int N = int.Parse(y[0]),                              
                K = int.Parse(y[1]),                              
                HowLongWillBeTheArr = y[0].Length;                
            int[] arrDigits = Array.ConvertAll<string, int>(System.Text.RegularExpressions.Regex.Split(N.ToString(), @"(?!^)(?!$)"), str => int.Parse(str));
            Array.Reverse(arrDigits);
            int finalnumber = 0;
            for (int i = 0; i < arrDigits.Length; i++)
            {
                finalnumber += arrDigits[i] * Convert.ToInt32(Math.Pow(10, arrDigits.Length - i - 1));
            }
            Console.WriteLine((finalnumber/K)+(finalnumber % K));
        }
    }
}
