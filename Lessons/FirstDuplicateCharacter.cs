using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSALesson.Lessons
{
    public class FirstDuplicateCharacter
    {
        public static void Run()
        {
            string h = "hello";
            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < h.Length; i++)
            {
                char currentChar = h[i];

                if (counts.ContainsKey(currentChar))
                {
                    Console.WriteLine(currentChar);
                    break;
                }
                else
                {
                    counts[currentChar] = 1; 
                }
            }
        }
    }
}