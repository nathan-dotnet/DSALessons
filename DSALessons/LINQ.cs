using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class LINQ
    {
        public static void Run()
        {

            string[] sensorIds = {"S1", "S2", "S1", "S3", "S2"};

            sensorIds
            .GroupBy(sensor => sensor)
            .ToList()
            .ForEach(group => Console.WriteLine(group.Key + ": " + group.Count()));

            var result = sensorIds
                .GroupBy(sensor => sensor)
                .Where(group => group.Count() > 1)
                .First();   
                Console.WriteLine(result.Key);


        }
    }
}