using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8__Columns_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(int.Parse(Console.ReadLine()));
            foreach (var val in Console.ReadLine().Split(' '))
            {
                nums.Add(int.Parse(val));
            }
            
            nums.Sort();

            
            Console.WriteLine(nums[nums.Count - 1]);
            
        }
    }
}
