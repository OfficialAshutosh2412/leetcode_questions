using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrep
{
    class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            int remains, sum = 0, temp = x;
            while(x>0)
            {
                remains = x % 10;
                sum = (sum * 10) + remains;
                x /= 10;
            }
            if (sum == temp)
            {
                return true;
            }
            return false;

        }
        //public static void Main()
        //{
        //    Palindrome p = new Palindrome();
        //    bool result = p.IsPalindrome(10);
        //    Console.WriteLine(result);
        //}
    }
}
