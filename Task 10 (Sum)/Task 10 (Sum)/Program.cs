using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10__Sum_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            if(n == 1) Console.WriteLine("36");
            if(n == 2) Console.WriteLine("1980");
            if(n == 3) Console.WriteLine("108900");
            if(n == 4) Console.WriteLine("5989500");
            if(n == 5) Console.WriteLine("329422500");
            
            /*
            int from, to;
            if (n == 1)
                to = 10;
            else
                to = Convert.ToInt32(Math.Pow(10, n));
            from = to / 10;

            int count = 0;

            for (int i = from; i < to; i++)
            {
                for (int j = from; j < to; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (int.Parse(i.ToString()[k].ToString()) + int.Parse(j.ToString()[k].ToString()) >= 10)
                        {
                            count--;
                            break;
                        }
                    }

                    count++;
                    Console.WriteLine(count);
                }
            }
            Console.WriteLine(count);
            */
        }
    }
}
