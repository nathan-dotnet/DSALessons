using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class LargestEvenNumber
    {
        public static void Run()
        {
            //Given an array, find the largest EVEN number.

            int[] nums = {3, 8, 1, 4, 6, 7};   // expect 8

            int even = 0; 

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && nums[i] > even)
                {
                even = nums[i];
                }
            }

            Console.WriteLine(even);
        }
    }
}