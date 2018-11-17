using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication139
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int Number = int.Parse(Console.ReadLine());
                var arr = Number.ToString().Select(t => int.Parse(t.ToString())).ToArray();
                int even = 0;
                int odd = 0;
                for (int p = 0; p < 4; p++)
                {
                    
                    if(arr[p] % 2 ==0)
                    {
                        even += arr[p];
                    }
                    if(arr[p] % 2 !=0)
                    {
                        odd += arr[p];
                    }
                }
                if(even > odd)
                {
                    Console.WriteLine("left");
                }
                if(even < odd)
                {
                    Console.WriteLine("right");  
                }
                if(odd == even)
                {
                    Console.WriteLine("straight");
                }
            }

        }
    }
}
