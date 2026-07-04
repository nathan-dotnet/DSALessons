using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class FIFO
    {
        public static void Run()
        {
            // Sensors trigger alerts in this order:
            // string[] alerts = {"S1:High Temp", "S2:Low Pressure", 
            //                 "S3:Vibration", "S1:Overheat"};

            // Process alerts in the ORDER they came in.
            // Print each alert as it gets processed.

            // Expected output:
            // Processing: S1:High Temp
            // Processing: S2:Low Pressure
            // Processing: S3:Vibration
            // Processing: S1:Overheat

            string[] alerts = {"S1: High Temp", "S2:Low Pressure", "S3:Vibration", "S1:Overheat"};

            Queue<string> alertQueue = new Queue<string>();
            //Step 1: add all alerts into the queue
            for (int i = 0; i < alerts.Length; i++)
            {
                alertQueue.Enqueue(alerts[i]);  
            }
            //Step 2: process each alert one by one
            while (alertQueue.Count > 0)
            {
                // how do you take from the front of the queue?
                // then print "Processing: " + that alert
                string current = alertQueue.Dequeue();
                Console.WriteLine($"Processing: " + current);
            }
        }
    }
}