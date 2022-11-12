/*
895. Maximum Frequency Stack
Hard

Design a stack-like data structure to push elements to the stack and pop 
the most frequent element from the stack.

Implement the FreqStack class:

FreqStack() constructs an empty frequency stack.
void push(int val) pushes an integer val onto the top of the stack.
int pop() removes and returns the most frequent element in the stack.
If there is a tie for the most frequent element, the element closest to the stack's 
top is removed and returned. 

Example 1:

Input
["FreqStack", "push", "push", "push", "push", "push", "push", "pop", "pop", "pop", "pop"]
[[], [5], [7], [5], [7], [4], [5], [], [], [], []]
Output
[null, null, null, null, null, null, null, 5, 7, 5, 4]

Explanation
FreqStack freqStack = new FreqStack();
freqStack.push(5); // The stack is [5]
freqStack.push(7); // The stack is [5,7]
freqStack.push(5); // The stack is [5,7,5]
freqStack.push(7); // The stack is [5,7,5,7]
freqStack.push(4); // The stack is [5,7,5,7,4]
freqStack.push(5); // The stack is [5,7,5,7,4,5]
freqStack.pop();   // return 5, as 5 is the most frequent. The stack becomes [5,7,5,7,4].
freqStack.pop();   // return 7, as 5 and 7 is the most frequent, but 7 is closest to the top. The stack becomes [5,7,5,4].
freqStack.pop();   // return 5, as 5 is the most frequent. The stack becomes [5,7,4].
freqStack.pop();   // return 4, as 4, 5 and 7 is the most frequent, but 4 is closest to the 
top. The stack becomes [5,7]. 

Constraints:

0 <= val <= 109
At most 2 * 104 calls will be made to push and pop.
It is guaranteed that there will be at least one element in the stack before calling pop.
*/

/**
 * Your FreqStack object will be instantiated and called as such:
  FreqStack obj = new FreqStack();
  obj.Push(val);
  int param_2 = obj.Pop();
 */
using System;
using System.Collections.Generic;

namespace MaximumFrequencyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 8;
            FreqStack obj = new FreqStack();
            obj.Push(val);
            int param_2 = obj.Pop();

        }

    }
    public class FreqStack
    {
        private readonly Dictionary<int, int> freqs;
        private readonly Dictionary<int, Stack<int>> dict;
        private readonly Stack<int> peek;

        public FreqStack()
        {
            freqs = new Dictionary<int, int>();
            dict = new Dictionary<int, Stack<int>>();
            peek = new Stack<int>();
        }

        public void Push(int val)
        {
            if (freqs.ContainsKey(val)) { freqs[val]++; }
            else { freqs.Add(val, 1); }

            var freq = freqs[val];

            if (dict.ContainsKey(freq)) { dict[freq].Push(val); }
            else
            {
                var st = new Stack<int>();
                st.Push(val);
                dict.Add(freq, st);
                peek.Push(freq);
            }
        }

        public int Pop()
        {
            var key = peek.Peek();
            var st = dict[key];
            var val = st.Pop();

            if (st.Count == 0)
            {
                dict.Remove(key);
                peek.Pop();
            }
            freqs[val]--;

            System.Console.WriteLine(val);
            return val;
        }
    }
}
