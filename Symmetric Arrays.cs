using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication148
{
    class Program
    {
        static void Main(string[] args)
        {
            int howmanyArr = int.Parse(Console.ReadLine());
            for (int i = 0; i < howmanyArr; i++)
            {
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                bool isSymetric = true;
                for (int z = 0; z < (arr.Length+1)/2; z++)
                {
                    if (arr[z] != arr[arr.Length-z-1])
                    {
                        isSymetric = false;
                        break;
                    }
                }
                if (isSymetric == true)
                {
                    Console.WriteLine("Yes");
                }
                if(isSymetric == false)
                {
                    Console.WriteLine("No");
                }    
            }
            
        }
    }
}
