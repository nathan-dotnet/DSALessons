using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class CountEvenNumbers
    {
        public static void Run()
        {
            //Given an array, count how many EVEN numbers are in it.

            int[] nums = {3, 8, 1, 4, 6, 7};
            //Expected output: 3   (8, 4, 6 are even)

            int even = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                   even = even + 1;
                }
            }

            Console.WriteLine(even);

        }
    }
}