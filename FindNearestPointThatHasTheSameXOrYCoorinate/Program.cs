/*
1779. Find Nearest Point That Has the Same X or Y Coordinate
Easy
You are given two integers, x and y, which represent your current location on 
a Cartesian grid: (x, y). You are also given an array points where each 
points[i] = [ai, bi] represents that a point exists at (ai, bi). A point 
is valid if it shares the same x-coordinate or the same y-coordinate as your location.

Return the index (0-indexed) of the valid point with the smallest Manhattan 
distance from your current location. If there are multiple, return the valid point 
with the smallest index. If there are no valid points, return -1.

The Manhattan distance between two points (x1, y1) and (x2, y2) is 
abs(x1 - x2) + abs(y1 - y2).

Example 1:

Input: x = 3, y = 4, points = [[1,2],[3,1],[2,4],[2,3],[4,4]]
Output: 2
Explanation: Of all the points, only [3,1], [2,4] and [4,4] are valid. Of the valid 
points, [2,4] and [4,4] have the smallest Manhattan distance from your current 
location, with a distance of 1. [2,4] has the smallest index, so return 2.
Example 2:

Input: x = 3, y = 4, points = [[3,4]]
Output: 0
Explanation: The answer is allowed to be on the same location as your current location.
Example 3:

Input: x = 3, y = 4, points = [[2,3]]
Output: -1
Explanation: There are no valid points.
 

Constraints:

1 <= points.length <= 104
points[i].length == 2
1 <= x, y, ai, bi <= 104
*/

using System;
using System.Linq;

namespace FindNearestPointThatHasTheSameXOrYCoorinate
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 4;
            int[][] points = new int[][]
            {
                new int[] {1,2},
                new int[] {3,1},
                new int[] {2,4},
                new int[] {2,3},
                new int[] {4,4}
            };

            var res = NearestValidPoint( x, y, points);
            Console.WriteLine(res);
        }

        private static int NearestValidPoint(int x, object y, int[][] points)
        {
            var nrst = -1;
            var minDist  =int.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                var pX = points[i][0];
                var pY = points[i][1];

                if(x == pX || y == pY)
                {
                    var dist = Math.Abs(x - pX) + Math.Abs(y - pY);
                    if(dist<minDist)
                    {
                        minDist = dist;
                        nrst = i;
                    }
                }
            }
            return nrst;
        }
    }
}
