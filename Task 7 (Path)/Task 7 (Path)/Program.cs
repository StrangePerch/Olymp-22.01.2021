using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7__Path_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cords_line = Console.ReadLine().Split(' ');
            List<int> cords = new List<int>();
            
            foreach (var val in cords_line)
            {
                int cord = int.Parse(val);
                cords.Add(cord);
            }

            int length = 0;

            cords.Sort();
            
            for (int i = 0; i < n - 1; i++)
            {
                length += Math.Abs(cords[i] - cords[i + 1]);
            }

            length += Math.Abs(cords[0] - cords[n - 1]);
            Console.WriteLine(length);
        }
    }
}
