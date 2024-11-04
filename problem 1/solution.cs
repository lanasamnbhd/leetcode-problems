using System;
using System.Collections.Generic;

class Program
{
    static int[] TwoSum(int[] nums, int target)
    {
        // Dictionary to store the number and its index
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            
            // Check if the complement is already in the dictionary
            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
            }
            
            // If not, add the current number and its index to the dictionary
            numDict[nums[i]] = i;
        }
        
        // If no solution is found, return an empty array
        return new int[0];
    }

    static void Main()
    {
        Console.WriteLine("Enter numbers in the array separated by spaces:");
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = Array.ConvertAll(input, int.Parse);

        Console.WriteLine("Enter the target number:");
        int target = int.Parse(Console.ReadLine());

        int[] result = TwoSum(nums, target);

        if (result.Length > 0)
        {
            Console.WriteLine("Indices of the two numbers that add up to the target: [{0}, {1}]", result[0], result[1]);
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
