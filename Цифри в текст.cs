using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication141
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = Console.ReadLine();
            bool IfNoNUmbers = true;
            int result = 0;
            int tempNumber = 0;
            foreach(char s in Text)
            {
                if (char.IsDigit(s))
                {
                    IfNoNUmbers = false;
                    tempNumber = int.Parse(s.ToString());
                    result += tempNumber;
                    tempNumber = 0;
                }

            }
            if (IfNoNUmbers == false)
            {
                Console.WriteLine(result);
            }
            if (IfNoNUmbers == true)
            {
                Console.WriteLine(-1);
            }
                
        }
    }
}
