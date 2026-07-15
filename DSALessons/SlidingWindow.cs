using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class SlidingWindow
    {
        public static void Run()
        {
            double[] readings = {72.5, 68.0, 95.3, 71.2, 60.1, 75.0};
            int currentSteak = 0;
            int longestSteak = 0;

            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= 60.0 && readings[i] <= 80.0)
                {
                    currentSteak++;
                    if (currentSteak > longestSteak)
                    {
                        longestSteak = currentSteak;
                    }
                }
                else
                {
                    currentSteak = 0;
                }
            }
            Console.WriteLine("Longest streak: " + longestSteak);
        }
    }
}