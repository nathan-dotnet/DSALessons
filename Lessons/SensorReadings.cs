using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class SensorReadings
    {
        public static void Run()
        {
            // //Sensor readings (simulate this as a starting array):
            double[] readings = {72.5, 68.0, 95.3, 71.2, 60.1};

            double Highest = readings[0];
            double Lowest = readings[0];

            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > Highest)
                {
                    Highest = readings[i];
                }
                else if (readings[i] < Lowest)
                {
                    Lowest = readings[i];
                }
            }

            Console.WriteLine($"Highest:" + Highest);
            Console.WriteLine($"Lowest:" + Lowest);

            //Find the highest and lowest reading.
            //Expected output:
            //Highest: 95.3
            //Lowest: 60.1
        }
    }
}