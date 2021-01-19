using System;

namespace Task_4__Chess_
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();
            string letter = line[0].ToString();
            var num = int.Parse(line[1].ToString());
            int pair = letter.IndexOfAny(new[] {'A', 'C', 'E', 'G'});
            if ((num + pair) % 2 == 1)
                Console.WriteLine("BLACK");
            else
                Console.WriteLine("WHITE");
        }
    }
}
