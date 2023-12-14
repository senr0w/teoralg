using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
      int [] nums = { 2, 7, 11, 15 };
      int target = 9;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j]== target)
                {
        
                    Console.WriteLine(nums[i] + nums[j]);
                }
            }
        }
    }
}