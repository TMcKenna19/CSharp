using System;
using System.Collections.Generic;


namespace Puzzels
{
    class Program
    {
        static void Main(string[] args)
        {
                
        //    RandomArray();
        //    TossCoin();
           var result = Names();


        }
        //Create a function called RandomArray() that returns an integer array
                // Place 10 random integer values between 5-25 into the array
                // Print the min and max values of the array
                // Print the sum of all the value
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] nums = new int[10];

            for(var i=0; i<nums.Length; i++)
                nums[i] = rand.Next(5,26);
            
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int sum = 0;

            foreach(var num in nums)
            {
                sum += num;
                if(min > num)
                    min = num;
                if(max < num)
                    max = num;
            }
            Console.WriteLine($"Min: {min}, Max: {max}, Sum {sum}");
            return nums;
        }
        // Create a function called TossCoin() that returns a string
        // Have the function print "Tossing a Coin!"
        // Randomize a coin toss with a result signaling either side of the coin 
        // Have the function print either "Heads" or "Tails"
        // Finally, return the result
        public static double TossMultiple(int numTimes)
        {
            Random rand = new Random();
            int numHeads = 0;
            for(var toss = 0; toss < numTimes; toss++)
            {
                if(rand.Next(2) == 0)
                    numHeads++;
            }
            return (double)numHeads/numTimes;
        }
        public static string TossCoin()
        {
            Random rand = new Random();
            string result;

            if(rand.Next(2) == 0)
                result = "Heads";
            else 
                result = "Tails";
             
            Console.WriteLine($"The result is: {result}");
            return result;

        }
        // Build a function Names that returns a list of strings.  In this function:
        // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
        // Shuffle the list and print the values in the new order
        // Return a list that only includes names longer than 5 characters
        public static List<string>Names()
        {
            List<string> names = new List<string>()
            {
                "Todd", "Tiffany", "Charlie", "Geneva","Sydney"
            };

            Random rand = new Random();

            for(var i = 0; i<names.Count/2; i++)
            {
                int randomIndex = rand.Next(names.Count);
                string temp = names[randomIndex];
                names[randomIndex] = names[i];
                names[i] = temp;
            }
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            for(var i = 0; i <names.Count; i++)
            {
                if(names[i].Length <= 5)
                    names.RemoveAt(i);
            }
            
            return names;
        }
    }
}
