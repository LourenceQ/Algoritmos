/*
118. Pascal's Triangle 
Given an integer numRows, return the first numRows of Pascal's 
triangle.

In Pascal's triangle, each number is the sum of the two numbers 
directly above it as shown:

Example 1:

Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
Example 2:

Input: numRows = 1
Output: [[1]]
 

Constraints:

1 <= numRows <= 30
*/
using System.Collections.Generic;

namespace PascalsTriangleII
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowIndej = 3;
            GetRow(rowIndej);
        }

        public static IList<int> GetRow(int rowIndex)
        {
            IList<int> res = new List<int>();
            IList<int> last = new List<int>();

            res.Add(1);

            for (int i = 1; i <= rowIndex; i++)
            {
                last = res;
                res = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        res.Add(1);
                    }
                    else
                    {
                        res.Add((last[j - 1] + last[j]));
                    }
                }
            }

            return res;
        }
    }
}
