using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication161
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string [] y = x.Split(' ');
            int firstNumber = 0;
            int secondNumber = 0;
            var arrFirst = y[0].Select(t => int.Parse(t.ToString())).ToArray();
            var arrSecond = y[1].Select(t => int.Parse(t.ToString())).ToArray();
            
            Array.Reverse(arrFirst);
            Array.Reverse(arrSecond);
            
            for (int i = 0; i < arrFirst.Length; i++)
            {
                firstNumber += arrFirst[i] * Convert.ToInt32(Math.Pow(10, arrFirst.Length - i - 1));
                secondNumber += arrSecond[i] * Convert.ToInt32(Math.Pow(10, arrSecond.Length - i - 1));
                
            }
            int result = Math.Max(firstNumber,secondNumber);
            Console.WriteLine(result);

        }
    }
}
