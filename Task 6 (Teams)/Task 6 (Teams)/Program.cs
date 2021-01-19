using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6__Teams_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var line = Console.ReadLine().Split(' ');
            int a = 0, b = 0;
            foreach (var val in line)
            {
                if (val == "1")
                    a++;
                else
                    b++;
            }
            
            Console.WriteLine(Math.Min(a,b));
        }
    }
}
