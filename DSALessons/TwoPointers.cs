using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class TwoPointers
    {
        public static void Run()
        {
            //Given a SORTED array of timestamps (in seconds), find if ANY two readings happened within 10 seconds of each other.
            int[] timestamps = {1, 5, 12, 23, 30};

            int limit = 10;
            int left = 0;
            int right = 1;
            bool found = false;

            while (right < timestamps.Length)
            {
                if (timestamps[right] - timestamps[left] <= limit)
                {
                    found = true;
                    break;
                }
                else
                {
                    left++; right++;
                }       
            }
        Console.WriteLine(found);
        return;
        }
    }
}