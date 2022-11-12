/*
1502. Can Make Arithmetic Progression From Sequence
Easy
A sequence of numbers is called an arithmetic progression if the 
difference between any two consecutive elements is the same.

Given an array of numbers arr, return true if the array can be 
rearranged to form an arithmetic progression. Otherwise, return false.

Example 1:

Input: arr = [3,5,1]
Output: true
Explanation: We can reorder the elements as [1,3,5] or [5,3,1] with differences 
2 and -2 respectively, between each consecutive elements.
Example 2:

Input: arr = [1,2,4]
Output: false
Explanation: There is no way to reorder the elements to obtain an arithmetic progression.
 

Constraints:

2 <= arr.length <= 1000
-106 <= arr[i] <= 106
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace CanMakeArithmeticProgressionFromSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 1 };
            var res = CanMakeArithmeticProgression(arr);
            Console.WriteLine(res);
        }

        private static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);

            return arr.Select((x, i) => (x, i))
                .Where(x => x.i > 0)
                .Select(x => arr[x.i] - arr[x.i - 1])
                .Distinct().Count() == 1;
        }
        public bool CanMakeArithmeticProgression2(int[] arr)
        {

            if (arr == null || arr.Length < 3)
                return true;

            int min = Int32.MaxValue, max = Int32.MinValue;
            HashSet<int> set = new HashSet<int>();
            foreach (var num in arr)
            {
                min = Math.Min(min, num);
                max = Math.Max(max, num);
                set.Add(num);
            }

            int n = arr.Length, k = 1;
            if (((max - min) / (n - 1)) % 1 != 0)
                return false;

            int diff = (max - min) / (n - 1);
            for (int i = 1; i < n; i++)
            {
                if (!set.Contains(min + i * diff))
                    return false;
            }

            return true;
        }
    }
}
