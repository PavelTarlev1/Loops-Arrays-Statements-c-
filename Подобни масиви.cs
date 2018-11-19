using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication157
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrONELenght = int.Parse(Console.ReadLine());
            int[] arrOne = Console.ReadLine().Split(' ').Distinct().Select(int.Parse).ToArray();
            int arrTHOLenght = int.Parse(Console.ReadLine());
            int[] arrTHO = Console.ReadLine().Split(' ').Distinct().Select(int.Parse).ToArray();
            bool ifEqual = true;
            Array.Sort(arrOne);
            Array.Sort(arrTHO);
            if (arrOne.Length == arrTHO.Length)
            {
                for (int i = 0; i < arrOne.Length; i++)
                {
                    if (arrOne[i] != arrTHO[i])
                    {
                        ifEqual = false;
                        break;
                    }
                }
                if (ifEqual == true)
                {
                    Console.WriteLine(arrTHO.Length);
                }
            }

            if (ifEqual == false | arrOne.Length != arrTHO.Length)
            {
                string result ="";
                
                for (int i = 0; i < arrOne.Length; i++)
                {
                    bool ifexsist = false;
                    for (int z = 0; z < arrTHO.Length; z++)
                    {
                        if (arrOne[i] == arrTHO[z])
                        {
                            ifexsist = true;
                            break;
                        }
                    }
                    if (ifexsist == false)
                    {
                        result += arrOne[i] + " ";
                    }
                }
                result = result.Remove(result.Length - 1);
                Console.WriteLine(result);
            }
        }
    }
}
