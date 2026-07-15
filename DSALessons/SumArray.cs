using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class SumArray
    {
        public static void Run()
        {
            int[] nums = {4, 2, 7, 1, 5};
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                    sum = nums[i] + sum;

            }

            Console.WriteLine(sum);
        }
    }
}