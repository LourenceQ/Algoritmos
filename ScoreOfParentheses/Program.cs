/*
856. Score of Parentheses
Medium
Given a balanced parentheses string s, return the score of the string.

The score of a balanced parentheses string is based on the following rule:

"()" has score 1.
AB has score A + B, where A and B are balanced parentheses strings.
(A) has score 2 * A, where A is a balanced parentheses string.
 
Example 1:

Input: s = "()"
Output: 1
Example 2:

Input: s = "(())"
Output: 2
Example 3:

Input: s = "()()"
Output: 2
 
Constraints:

2 <= s.length <= 50
s consists of only '(' and ')'.
s is a balanced parentheses string.
*/

using System;
using System.Collections.Generic;

namespace ScoreOfParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "(()(()))";
            var res = ScoreOfParentheses2(s);

            Console.WriteLine(res);
        }

        public static int ScoreOfParentheses(string s)
        { 
            Stack<int> myStack = new Stack<int>();  
            myStack.Push(0);        

            if(s == null ) return 0;

            for (int x = 0; x < s.Length; x ++)
            {
                if(s[x] == '(')
                {
                    myStack.Push(0);
                }
                else
                {
                    int v = myStack.Pop();
                    int w = myStack.Pop();
                    myStack.Push(w + Math.Max(2 * v, 1));
                }                
            }
            return myStack.Pop();
        }

        public static int ScoreOfParentheses2(string s)
        {
            int count = 0, bal = 0;
            for(int x = 0; x < s.Length; x ++)
            {
                if(s[x] == '(')
                {
                    bal++;
                }
                else 
                {
                    bal--;
                    if(s[x-1] == '(')
                        count += 1 << bal;
                }
            }

            return count;
        }
    }
}

/*
Every position in the string has a depth - some number of matching parentheses surrounding it. For example, the dot in (()(.())) has depth 2, because of these parentheses: (__(.__))

Our goal is to maintain the score at the current depth we are on. When we see an opening bracket, we increase our depth, and our score at the new depth is 0. When we see a closing bracket, we add twice the score of the previous deeper part - except when counting (), which has a score of 1.

For example, when counting (()(())), our stack will look like this:

[0, 0] after parsing (
[0, 0, 0] after (
[0, 1] after )
[0, 1, 0] after (
[0, 1, 0, 0] after (
[0, 1, 1] after )
[0, 3] after )
[6] after )
*/
