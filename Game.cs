using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication69
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Number = int.Parse(Console.ReadLine());
            Number = Math.Abs(Number);
            int Result=1 ;
            int ArrLenght = Number.ToString().Length;
            int[] arr = new int[ArrLenght];
            for (int i = 0; i < ArrLenght; i++)
            {
                arr[i] = Number % 10;
                Number /= 10;
            }
            Result = Math.Max(Result, arr[0] + arr[1] + arr[2]);
            Result = Math.Max(Result, arr[0] + arr[1] * arr[2]);
            Result = Math.Max(Result, arr[0] * arr[1] + arr[2]);
            Result = Math.Max(Result, arr[0] * arr[1] * arr[2]);
            Console.WriteLine(Result);
        }
    }
}
