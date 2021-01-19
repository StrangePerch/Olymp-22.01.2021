using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9__Circle_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var line = Console.ReadLine().Split(' ');

            int num = 1;

            while (true)
            {
                int count = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    if (line[i] == line[i + 1] && line[i] == num.ToString())
                        count++;
                }


                if (line[0] == line[n - 1] && line[0] == num.ToString())
                        count++;

                if (count >= 2)
                {
                    Console.WriteLine("Yes");
                    return;
                }

                num++;
                if (num > 50)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
        }
    }
}
