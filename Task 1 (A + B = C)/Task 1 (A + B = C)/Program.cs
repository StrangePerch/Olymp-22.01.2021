using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1__A___B___C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            var nums = Console.ReadLine().Split(' ');
            a = int.Parse(nums[0]);
            b = int.Parse(nums[1]);
            c = int.Parse(nums[2]);

            if(a + b == c || b + c == a || a + c == b)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }
}
