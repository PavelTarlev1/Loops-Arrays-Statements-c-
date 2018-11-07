using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {
            int HowLongArr = int.Parse(Console.ReadLine());
            int [] arr = new int [HowLongArr];
            int finalresult = 0;
            int whatNumber = 0;
            int bufferNumber = 1;
            int result = 1 ;
            for (int i = 0; i < HowLongArr; i++)
			{
                arr[i] = int.Parse(Console.ReadLine());
			}
            for (int i = 0; i < HowLongArr; i++)
            {
                for (int p = 1; p < HowLongArr; p++)
                {
                    if(arr[i]== arr[p])
                    {
                        bufferNumber++;
                        if (result < bufferNumber)
                        {
                            result = bufferNumber;
                        }
                    }
                }
                if(result > finalresult)
                {
                    finalresult = result;
                    whatNumber = arr[i];
                }
                bufferNumber = 0;

            }
            Console.WriteLine("{0}({1} times)",whatNumber ,finalresult);
                     
        }
    }
}
