/*
The array-form of an integer num is an array representing its digits in left to right order.

For example, for num = 1321, the array form is [1,3,2,1].
Given num, the array-form of an integer, and an integer k, return the array-form of the integer num + k.

 

Example 1:

Input: num = [1,2,0,0], k = 34
Output: [1,2,3,4]
Explanation: 1200 + 34 = 1234
Example 2:

Input: num = [2,7,4], k = 181
Output: [4,5,5]
Explanation: 274 + 181 = 455
Example 3:

Input: num = [2,1,5], k = 806
Output: [1,0,2,1]
Explanation: 215 + 806 = 1021
 

Constraints:

1 <= num.length <= 104
0 <= num[i] <= 9
num does not contain any leading zeros except for the zero itself.
1 <= k <= 104
*/
using static System.Console;

namespace AddToArrayFormOfInteger;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,0,0};
        int k = 34;

        var res = AddToArrayForm(arr, k);
        foreach (var item in res)
        {
            WriteLine($"Resposta: {item}");
        }
    }

    public static IList<int> AddToArrayForm(int[] arr, int k)
    {
        List<int> res = new();

        int idx = arr.Length - 1;
        int shift = 0;

        while(idx >= 0 || k != 0)
        {
            int val1 = idx >= 0 ? arr[idx] : 0;
            int val2 = k != 0 ? k %10 : 0;

            int sum = val1 + val2 + shift;
            int digit = sum % 10;
            shift = sum / 10;

            res.Add(digit);
            idx -- ;
            k = k /10;
        }

        if(shift != 0)
        {
            res.Add(shift);
        }

        res.Reverse();

        return res;
    }
}