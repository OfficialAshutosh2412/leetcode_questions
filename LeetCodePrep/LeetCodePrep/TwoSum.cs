using System;

namespace LeetCodePrep
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new ArgumentException("can't find index");

        }
    }
    class TwoSum
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 2,8,6,18};
        //    int aim = 20;
        //    Solution s1 = new Solution();
        //    int[] sum = s1.TwoSum(arr, aim);
        //    for (int i = 0; i < sum.Length; i++)
        //    {
        //        Console.Write(sum[i]+" ");
        //    }
        //}
    }
}
