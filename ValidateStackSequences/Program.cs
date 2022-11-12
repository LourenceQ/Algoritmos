/*
946. Validate Stack Sequences
Medium
Given two integer arrays pushed and popped each with distinct values, return true if this could 
have been the result of a sequence of push and pop operations on an initially empty stack, or false otherwise.

Example 1:

Input: pushed = [1,2,3,4,5], popped = [4,5,3,2,1]
Output: true
Explanation: We might do the following sequence:
push(1), push(2), push(3), push(4),
pop() -> 4,
push(5),
pop() -> 5, pop() -> 3, pop() -> 2, pop() -> 1
Example 2:

Input: pushed = [1,2,3,4,5], popped = [4,3,5,1,2]
Output: false
Explanation: 1 cannot be popped before 2.
 
Constraints:

1 <= pushed.length <= 1000
0 <= pushed[i] <= 1000
All the elements of pushed are unique.
popped.length == pushed.length
popped is a permutation of pushed.
*/
using System;
using System.Collections.Generic;

namespace ValidateStackSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] pushed = {1,2,3,4,5}, popped = {4,3,5,1,2};
            int[] pushed = {1,2,3,4,5}, popped = {4,5,3,2,1};
            var res = ValidateStackSequences(pushed, popped);
            Console.WriteLine(res);
        }

        public static bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var pushedLen = pushed.Length;
            
            int push = 0, pop = 0;
            
            var stack = new Stack<int>();

            while (push < pushedLen || pop < pushedLen)
            {
                if(stack.Count == 0)
                {
                    if( push >= pushedLen)
                    {
                        break;
                    }
                    stack.Push(pushed[push++]);
                }
                else if(popped[pop] == stack.Peek())
                {
                    stack.Pop();
                    pop++;
                }
                else if(push < pushedLen)
                {
                    stack.Push(pushed[push++]);
                }
                else
                {
                    break;
                }
            }

            return stack.Count == 0;
        }
    }
}
