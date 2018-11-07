using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication88
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            bool YesNo = card.All(char.IsDigit);
            if (YesNo == true)
            {
                int Number = int.Parse(card);
                if (Number >= 2 && Number <=10 )
                {
                    Console.WriteLine("yes {0}",Number);
                }
                if(Number >10 | Number<2)
                {
                    Console.WriteLine("no {0}",Number);
                }
                   
            }
            if (YesNo == false)
            {
                if (card == "J")
                {
                    Console.WriteLine("yes J");
                }
                if (card == "Q")
                {
                    Console.WriteLine("yes Q");
                }
                if (card == "K")
                {
                    Console.WriteLine("yes K");
                }
                if (card == "A")
                {
                    Console.WriteLine("yes A");
                }
                if (card != "A" & card != "J" & card != "K" & card !="Q")
                {
                    Console.WriteLine("no {0}",card);
                }
                
            }


        }

    }
}
