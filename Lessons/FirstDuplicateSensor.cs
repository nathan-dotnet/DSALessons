using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class FirstDuplicateSensor
    {
        public static void Run()
        {
            //Find the FIRST sensor ID that appears more than once.
            string[] sensorIds = {"S1", "S2", "S1", "S3", "S2"};
            Dictionary<string, int> counts = new Dictionary<string, int>();

                for (int i = 0; i < sensorIds.Length; i++)
                {
                    string currentSensor = sensorIds[i];

                    if (counts.ContainsKey(currentSensor))
                    {
                        Console.WriteLine(currentSensor);
                        break;
                    }
                    else
                    {
                        counts[currentSensor] = 1; 
                    }
                }


            //Expected output: S1

        }
    }
}