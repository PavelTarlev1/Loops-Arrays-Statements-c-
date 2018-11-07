using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication57
{
    class Program
    {
        static void Main(string[] args)
        {
            int HowLongArr = int.Parse(Console.ReadLine());
            int[] arr = new int[HowLongArr];
            int counter = 1;
            int finalResult = 1;
            for (int i = 0; i < HowLongArr; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < HowLongArr; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    counter = counter + 1;
                    if (counter > finalResult)
                        finalResult = counter;  
                }

                else
                {
                    counter = 1;
                }
                    
            }
            Console.WriteLine(finalResult);
        }
    }
}
