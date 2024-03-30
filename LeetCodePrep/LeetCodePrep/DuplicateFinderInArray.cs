using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrep
{
    class DuplicateFinderInArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int uni = 0;
            for (int cur = 0; cur < nums.Length; cur++)
            {
             
                if (nums[uni] != nums[cur])
                {
                    uni++;
                    nums[uni] = nums[cur];
                }
            }
            return uni;
        }
        public static void Main(string[] args)
        {
            int[] ar = { 1, 1, 2, 2, 3};
            DuplicateFinderInArray d1 = new DuplicateFinderInArray();
            int size = d1.RemoveDuplicates(ar);
            Console.WriteLine(size);
            for (int i = 0; i < size+1; i++)
            {
                Console.Write(ar[i] + ", ");
            }
        }
    }
    
}
