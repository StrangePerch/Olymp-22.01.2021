using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1__Who_have_the_biggest_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = Console.ReadLine().Split(' ');

            int p, m, o;
            p = int.Parse(scores[0]);
            m = int.Parse(scores[1]);
            o = int.Parse(scores[2]);

            if (p > m && p > o)
                Console.WriteLine("Petryk");
            if (m > p && m > o)
                Console.WriteLine("Marichka");
            if (o > m && o > p)
                Console.WriteLine("Olenka");

        }
    }
}
