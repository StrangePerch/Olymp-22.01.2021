using System;

namespace Task_5__Rectangle_
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            int x1, x2, y1, y2;
            x1 = int.Parse(line[0]);
            y1 = int.Parse(line[1]);
            x2 = int.Parse(line[2]);
            y2 = int.Parse(line[3]);

            if(x1 > x2)
                Console.WriteLine($"{x2} {y1} {x1} {y2}");
            else
                Console.WriteLine($"{x1} {y2} {x2} {y1}");
        }
    }
}
