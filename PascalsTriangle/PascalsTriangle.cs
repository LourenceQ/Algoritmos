/*
119. Pascal's Triangle II
Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

Example 1:

Input: rowIndex = 3
Output: [1,3,3,1]
Example 2:

Input: rowIndex = 0
Output: [1]
Example 3:

Input: rowIndex = 1
Output: [1,1]
 

Constraints:

0 <= rowIndex <= 33
 

Follow up: Could you optimize your algorithm to use only O(rowIndex) extra space?
*/
using System.Collections.Generic;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            int numRows = 5;
            var res = Generate(numRows);
            System.Console.WriteLine(res);
        }

        public static IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();

            var row = new List<int>();
            for (var i = 0; i < numRows; i++)
            {
                row.Add(1);
                for (var col = i - 1; col > 0; col--)
                {
                    row[col] += row[col - 1];
                }
                
                result.Add(new List<int>(row));
            }
            // foreach (var item in result)
            // {                
            //     foreach(var element in item)
            //     {
            //         System.Console.WriteLine(element);
            //     }
            // }

            return result;
        }
    }
}
