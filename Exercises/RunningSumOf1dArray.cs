using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeetCode;

namespace Exercises.LeetCode
{
    //1480. Running Sum of 1d Array
    public static class RunningSumOf1dArray
    {
        public static int[] RunningSum(int[] nums) 
        {
            for(int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i-1];
            }
            Console.WriteLine(nums.ValuesAsString());
            return nums;
        }
    }
}
