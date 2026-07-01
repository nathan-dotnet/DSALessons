using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class SensorCount
    {
        public static void Run()
        {
            //Same readings array, but now each reading has a sensor ID.

            string[] sensorIds = {"S1", "S2", "S1", "S3", "S2"};
            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < sensorIds.Length; i++)
            {
                string currentSensor = sensorIds[i];

                if (counts.ContainsKey(currentSensor))
                {
                    counts[currentSensor] = counts[currentSensor] + 1;
                    
                }
                else
                {
                    counts[currentSensor] = 1;
                }
            }
            // print all results AFTER the loop
            foreach (var entry in counts)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
            // Count how many readings came from each sensor.
            // Expected output:
            // S1: 2
            // S2: 2
            // S3: 1
        }
    }
}