using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication154
{
    class Program
    { 
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] y = x.Split(' ');
            int howMany = int.Parse(y[0]);
            var arr = y[1].ToString().Select((t => int.Parse(t.ToString()))).ToArray();
            int counter = 0;
            int result = 0;
            int finalresult = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==0)
                {
                    counter++;
                }
            }
            result = arr.Length - counter;
            finalresult = howMany - result;
            if(finalresult < 0)
            {
                Console.WriteLine("0");
            }
            if(finalresult >= 0)
            {
                Console.WriteLine(finalresult);
            }
        }
    }
}
