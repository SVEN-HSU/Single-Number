//https://leetcode.com/problems/single-number/
//time limit exceed :<
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 3, 55, 55, 0, 0, 2, 2, 1, 9 };
            Console.WriteLine("single number=" + SingleNumber_time_limit_exceed(nums));

            Console.WriteLine("xor different (1 ^ 2):" + (1 ^ 2));
            Console.WriteLine("xor same (1 ^ 1):" + (1 ^ 1));
            Console.WriteLine("xor same (0 ^ 3):" + (0 ^ 3));


            Console.Read();
        }

        static int SingleNumber_using_loop(int[] nums)
        {
            //ref: http://www.powerxing.com/leetcode-single-number/

            int result = 0;

            foreach (int p in nums)
            {
                result ^= p;
            }

            return result; 
        }


        static int SingleNumber_using_linq(int[] nums)
        {
            // ref: https://miafish.wordpress.com/2015/01/29/leetcode-oj-c-single-number/

            return nums.Aggregate(0, (current, i) => current ^ i);
        }

        static int SingleNumber_time_limit_exceed(int[] nums)
        {
            // My solution but failed.

            nums = nums.OrderBy(x => x).ToArray();

            if (nums.Length == 1)
            {
                return nums[0];
            }

            if (nums[0] != nums[1])
            {
                return nums[0];
            }

            if (nums[nums.Length - 1] != nums[nums.Length - 2])
            {
                return nums[nums.Length - 1];
            }


            for (int i = 0; i < nums.Length; i = i + 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }

            return 0;
        }
    }
}
