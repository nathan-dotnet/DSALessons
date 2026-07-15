using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class Async
    {
        public static async Task Run()
        {
            string[] sensorIds = {"S1", "S2", "S3"};
            double[] readings = {72.5, 68.0, 95.3};

            for (int i = 0; i < sensorIds.Length; i++)
            {
                Console.WriteLine("Reading from " + sensorIds[i] + "...");

                await Task.Delay(1000);

                Console.WriteLine(readings[i]);
            }
            Console.WriteLine("All sensors reported!");
        }
    }
}