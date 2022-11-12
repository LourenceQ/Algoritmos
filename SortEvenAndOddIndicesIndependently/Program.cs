using System;
using System.Collections.Generic;

namespace SortEvenAndOddIndicesIndependently
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 1, 2, 3, 5, 7, 6, 8 };
            SortEvenOdd(nums);
        }

        public static int[] SortEvenOdd(int[] nums)
        {
            var numsOdd = new List<int>();
            var numsEven = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 != 0)
                {
                    numsOdd.Add(nums[i]);
                }
                else
                {
                    numsEven.Add(nums[i]);
                }
            }

            numsOdd.Sort((a, b) => b - a);
            numsEven.Sort();

            int oddIndex = 0, evenIndex = 0;
            int[] res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 != 0)
                {
                    res[i] = numsOdd[oddIndex++];
                }
                else
                {
                    res[i] = numsEven[evenIndex++];
                }
            }
            // for (int i = 0; i < res.Length; i++)
            // {
            //     System.Console.WriteLine(res[i]);
            // }

            return res;
        }
    }
}


/*
    
        int[] res = new int[nums.Length];
        var odds = new List<int>(nums.Length / 2);
        var evens = new List<int>(nums.Length / 2);
        for (int i = 0; i < nums.Length; i++) {
            if (i % 2 == 0) evens.Add(nums[i]);
            else odds.Add(nums[i]);
        }

        evens.Sort();
        odds.Sort((a, b) => b - a);
        int ie = 0, io = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (i % 2 == 0) res[i] = evens[ie++];
            else res[i] = odds[io++];
        }
        return res;
*/