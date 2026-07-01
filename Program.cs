using DSALesson.Lessons;

// Choose which lesson to run

//LargestEvenNumber.Run();
// CountEvenNumbers.Run();
// LargestNumber.Run();
// SumArray.Run();
// FirstDuplicateCharacter.Run();
// string h = "hello";
    // Dictionary<char, int> counts = new Dictionary<char, int>();

    // for (int i = 0; i < h.Length; i++)
    // {
    //     char currentChar = h[i];

    //     if (counts.ContainsKey(currentChar))
    //     {
    //         Console.WriteLine(currentChar);
    //         break;
    //     }
    //     else
    //     {
    //         counts[currentChar] = 1; 
    //     }
    // }




// Given a string, find the FIRST character that appears more than once.

    // Input:  "swiss"
    // Output: 's'   (appears at index 0 and index 3)

    // Dictionary<char, int> counts = new Dictionary<char, int>();

    // // Add or update
    // counts['a'] = 5;

    // // Check if a key exists
    // if (counts.ContainsKey('a'))
    // {
    //     Console.WriteLine("found it");
    // }




//Given an array, find the largest EVEN number.

    // int[] nums = {3, 8, 1, 4, 6, 7};   // expect 8

    // int even = 0; 

    // for (int i = 0; i < nums.Length; i++)
    // {
    //     if (nums[i] % 2 == 0 && nums[i] > even)
    //     {
    //        even = nums[i];
    //     }
    // }

    // Console.WriteLine(even);




// //Given an array, count how many EVEN numbers are in it.

    // int[] nums = {3, 8, 1, 4, 6, 7};
    // //Expected output: 3   (8, 4, 6 are even)

    // int even = 0;

    // for (int i = 0; i < nums.Length; i++)
    // {
    //     if (nums[i] % 2 == 0)
    //     {
    //        even = even + 1;
    //     }
    // }

    // Console.WriteLine(even);




// //Given this array:
    // int[] nums = {3, 7, 1, 9, 4};

    // int largest = nums[0];

    // for (int i = 0; i < nums.Length; i++)
    // {
    //     if (nums[i] > largest)
    //     {
    //         largest = nums[i];
    //     }
    // }
    // // Write a loop that finds the largest number.
    // //Expected output: 9
    // Console.WriteLine(largest);



// int[] nums = {4, 2, 7, 1, 5};
    // int sum = 0;

    // for (int i = 0; i < nums.Length; i++)
    // {

    //         sum = nums[i] + sum;

    // }

    // Console.WriteLine(sum);



// //Sensor readings (simulate this as a starting array):
    // double[] readings = {72.5, 68.0, 95.3, 71.2, 60.1};

    // double Highest = readings[0];
    // double Lowest = readings[0];

    // for (int i = 0; i < readings.Length; i++)
    // {
    //     if (readings[i] > Highest)
    //     {
    //         Highest = readings[i];
    //     }
    //     else if (readings[i] < Lowest)
    //     {
    //         Lowest = readings[i];
    //     }
    // }

    // Console.WriteLine($"Highest:" + Highest);
    // Console.WriteLine($"Lowest:" + Lowest);

    //Find the highest and lowest reading.
    //Expected output:
    //Highest: 95.3
    //Lowest: 60.1

//Same readings array, but now each reading has a sensor ID.

    // string[] sensorIds = {"S1", "S2", "S1", "S3", "S2"};
    // Dictionary<string, int> counts = new Dictionary<string, int>();

    // for (int i = 0; i < sensorIds.Length; i++)
    // {
    //     string currentSensor = sensorIds[i];

    //     if (counts.ContainsKey(currentSensor))
    //     {
    //         counts[currentSensor] = counts[currentSensor] + 1;
            
    //     }
    //     else
    //     {
    //         counts[currentSensor] = 1;
    //     }
    // }
    // // print all results AFTER the loop
    // foreach (var entry in counts)
    // {
    //     Console.WriteLine(entry.Key + ": " + entry.Value);
    // }
    // Count how many readings came from each sensor.
    // Expected output:
    // S1: 2
    // S2: 2
    // S3: 1



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


