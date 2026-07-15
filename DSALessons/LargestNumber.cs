using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class LargestNumber
    {
        public static void Run()
        {
            //Given this array:
            int[] nums = {3, 7, 1, 9, 4};

            int largest = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > largest)
                {
                    largest = nums[i];
                }
            }
            // Write a loop that finds the largest number.
            //Expected output: 9
            Console.WriteLine(largest);
        }
    }
}