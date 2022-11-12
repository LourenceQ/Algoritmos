using System.Collections.Generic;
using System;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            String s =  ("{}{}");

            var res = IsValid(s);
            System.Console.WriteLine(res);
        }

        public static bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();        
        
        
        foreach(var item in s.ToCharArray())
        {
            if(item == '(' )
            {
                st.Push(')');
            }
            else if(item == '[' )
            {
                st.Push(']');
            }
            else if(item == '{' )
            {
                st.Push('}');
            }
            else if(st.Count == 0 || st.Pop() != item)
            {
                return false;
            }
        }
        
        return st.Count == 0;
        }
        public static bool IsValid2(string s)
        {
            // char[] c = s.ToCharArray();
            Stack<char> sStack = new Stack<char>();
            bool isValid;

            if (s.Length == 1) return false; 

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    sStack.Push(s[i]);
                }

                else if(s[i] == ')' && (sStack.Count !=1) && sStack.Peek() == '(')
                {
                    sStack.Pop();
                }

                else if(s[i] == ']' && (sStack.Count !=1) && sStack.Peek() == '[')
                {
                    sStack.Pop();
                }

                else if(s[i] == '}' && (sStack.Count !=1) && sStack.Peek() == '{')
                {
                    sStack.Pop();
                }

                else 
                {
                    sStack.Push(s[i]);                
                }                
            }
            if (sStack.Count != 1)
            {
                return isValid = true;
            }
            else return isValid = false;
           
        }
    }
}


