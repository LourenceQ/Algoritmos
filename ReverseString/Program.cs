/*
344. Reverse String
Easy
Write a function that reverses a string. The input string is given as an array 
of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.


Example 1:

Input: s = ['h','e','l','l','o']
Output: ['o','l','l','e','h']
Example 2:

Input: s = ['H','a','n','n','a','h']
Output: ['h','a','n','n','a','H']
 

Constraints:

1 <= s.length <= 105
s[i] is a printable ascii character.
*/

using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = {'h','e','l','l','o'};

            ReverseString(s);
            // var len = s.Length;

            // for (var i = 0; i < len / 2 ; i++)
            // {
            //     var temp = s[i];                
            //     s[i] = s[len - i - 1];                
            //     s[len - i - 1] = temp; 
            // }
        }

        public static void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                System.Console.Write(s[i] + " ");
            }

            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                char sTemp = s[end];
                s[end--] = s[start];
                s[start++] = sTemp;
            }

            System.Console.WriteLine(   );
            for (int i = 0; i < s.Length; i++)
            {
                System.Console.Write(s[i] + " ");
            }
        }
    }
}
