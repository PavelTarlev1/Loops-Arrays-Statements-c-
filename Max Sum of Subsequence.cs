using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication144
{
    class Program
    {
        static void Main(string[] args)
        {
            int HowLongArr = int.Parse(Console.ReadLine());
            int[] arr = new int[HowLongArr];
            int sum = 0;
            int result = 0;
            for (int i = 0; i < HowLongArr; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i];
                for (int d = 1+i; d < arr.Length;d++)
                {
                    sum += arr[d];
                    if(sum > result)
                    {
                        result = sum;
                    }      
                }
            }
            Console.WriteLine(result);
        }
    }
}
