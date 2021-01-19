using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Task_3__Football_
{
    class Program
    {
        static void Main(string[] args)
        {
            int UkraineHome, UkraineGuest, PotokHome, PotokGuest;

            var in1 = Console.ReadLine().Split(' ');
            var in2 = Console.ReadLine().Split(' ');

            UkraineHome = int.Parse(in1[0]);
            PotokGuest = int.Parse(in1[1]);
            UkraineGuest = int.Parse(in2[1]);
            PotokHome = int.Parse(in2[0]);

            int TotalU = UkraineHome + UkraineGuest;
            int TotalP = PotokGuest + PotokHome;


            if (TotalU > TotalP)
                Console.WriteLine("U");
            else if(TotalP == TotalU)
                if(PotokGuest > UkraineGuest)
                    Console.WriteLine("P");
                else if (PotokGuest < UkraineGuest)
                    Console.WriteLine("U");
                else
                    Console.WriteLine("T");
            else
                Console.WriteLine("P");
        }
    }
}
