/*
881. Boats to Save People
Medium
You are given an array people where people[i] is the weight of the ith person, 
and an infinite number of boats where each boat can carry a maximum weight of limit. 
Each boat carries at most two people at the same time, provided the sum of the weight 
of those people is at most limit.

Return the minimum number of boats to carry every given person. 

Example 1:

Input: people = [1,2], limit = 3
Output: 1
Explanation: 1 boat (1, 2)
Example 2:

Input: people = [3,2,2,1], limit = 3
Output: 3
Explanation: 3 boats (1, 2), (2) and (3)
Example 3:

Input: people = [3,5,3,4], limit = 5
Output: 4
Explanation: 4 boats (3), (3), (4), (5)
 

Constraints:

1 <= people.length <= 5 * 104
1 <= people[i] <= limit <= 3 * 104
*/

using System;
using static System.Console;

namespace BoatsToSavePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] people = {3,5,3,4};
            int limit = 5;

            // int[] people = {3,2,2,1};
            // int limit = 3;

            // int[] people = {1,2};
            // int limit = 3;

            var res = NumRescueBoats2(people, limit);
            WriteLine(res);
        }

        public static int NumRescueBoats(int[] people, int limit)
        {
            int res = 0;
            int n = people.Length;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += people[i];
            }
            // if(sum / limit == );

            return 0;
        }

        public static  int NumRescueBoats2(int[] people, int limit)
        {
            Array.Sort(people);
            int i = 0, j = people.Length-1, ans = 0;

            while(i <= j)
            {
                ans++;
                if(!(people[i] + people[j] <= limit))
                    i++;
                j--;
            }
            return ans;
        }
    }
}
