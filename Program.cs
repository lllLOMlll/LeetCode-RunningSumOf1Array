using System;

class Program
{
 public class Solution {
    public int[] RunningSum(int[] nums) {
        int sum = 0;
        int[] sumArray = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            sumArray[i] += sum;
           
        }

        return sumArray;
    }
}

    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = [1, 2, 3, 4];
        int[] nums2 = [2, 2 ,2 , 2];
        int[] result = solution.RunningSum(nums);
        int[] result2 = solution.RunningSum(nums2);
        // Print the result array
        Console.WriteLine(string.Join(", ", result));  
        Console.WriteLine(string.Join(", ", result2));
       
        
    }
}