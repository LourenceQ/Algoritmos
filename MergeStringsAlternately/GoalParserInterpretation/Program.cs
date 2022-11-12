/*
1678. Goal Parser Interpretation
Easy

You own a Goal Parser that can interpret a string command. The command 
consists of an alphabet of "G", "()" and/or "(al)" in some order. The Goal 
Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" 
as the string "al". The interpreted strings are then concatenated in 
the original order.

Given the string command, return the Goal Parser's interpretation of command.
 
Example 1:

Input: command = "G()(al)"
Output: "Goal"
Explanation: The Goal Parser interprets the command as follows:
G -> G
() -> o
(al) -> al
The final concatenated result is "Goal".
Example 2:

Input: command = "G()()()()(al)"
Output: "Gooooal"
Example 3:

Input: command = "(al)G(al)()()G"
Output: "alGalooG"
 

Constraints:

1 <= command.length <= 100
command consists of "G", "()", and/or "(al)" in some order.
*/

using System;
using System.Text;

namespace GoalParserInterpretation
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "G()(al)";
            var res = Interpret(command);
            Console.WriteLine(res);
        }

        private static object Interpret(string command)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;

            while (i < command.Length)
            {
                if (command[i] == 'G')
                {
                    sb.Append("G");
                    i++;
                }
                else if (command[i] == '(')
                {
                    if (command[i + 1] == ')')
                    {
                        sb.Append('o');
                        i += 2;
                    }
                    else
                    {
                        sb.Append("al");
                        i += 4;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
