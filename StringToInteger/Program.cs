using System;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "4193 with words";
            StateMachine Q = new StateMachine();
            for (int i = 0; i < s.Length && Q.getState() != State.qd; ++i)
            {
                Q.transition(s[i]);
            }

            // Console.WriteLine("Hello World!");
        }
    }

    // public class Solution
    // {
    //     public int MyAtoi(string s)
    //     {
    //         StateMachine Q = new StateMachine();

    //         for (int i = 0; i < s.Length && Q.getState() != State.qd; ++i)
    //         {
    //             Q.transition(s[i]);
    //         }

    //         return Q.getInteger();

    //     }
    // }

    enum State { q0, q1, q2, qd }

    class StateMachine
    {
        // Store current state value.
        private State currentState;
        // Store result formed and it's sign.
        private int result, sign;

        public StateMachine()
        {
            currentState = State.q0;
            result = 0;
            sign = 1;
        }

        // Transition to state q1.
        private void toStateQ1(char ch)
        {
            sign = (ch == '-') ? -1 : 1;
            currentState = State.q1;
        }

        // Transition to state q2.
        private void toStateQ2(int digit)
        {
            currentState = State.q2;
            appendDigit(digit);
        }

        // Transition to dead state qd.
        private void toStateQd()
        {
            currentState = State.qd;
        }

        // Append digit to result, if out of range return clamped value.
        private void appendDigit(int digit)
        {
            if ((result > Int32.MaxValue / 10) ||
                (result == Int32.MaxValue / 10 && digit > Int32.MaxValue % 10))
            {
                if (sign == 1)
                {
                    // If sign is 1, clamp result to Integer.MAX_VALUE.
                    result = Int32.MaxValue;
                }
                else
                {
                    // If sign is -1, clamp result to Integer.MIN_VALUE.
                    result = Int32.MinValue;
                    sign = 1;
                }

                // When the 32-bit int range is exceeded, a dead state is reached.
                toStateQd();
            }
            else
            {
                // Append current digit to the result. 
                result = result * 10 + digit;
            }
        }

        // Change state based on current input character.
        public void transition(char ch)
        {
            if (currentState == State.q0)
            {
                // Beginning state of the string (or some whitespaces are skipped).
                if (ch == ' ')
                {
                    // Current character is a whitespaces.
                    // We stay in same state. 
                    return;
                }
                else if (ch == '-' || ch == '+')
                {
                    // Current character is a sign.
                    toStateQ1(ch);
                }
                else if (Char.IsDigit(ch))
                {
                    // Current character is a digit.
                    toStateQ2(ch - '0');
                }
                else
                {
                    // Current character is not a space/sign/digit.
                    // Reached a dead state.
                    toStateQd();
                }
            }
            else if (currentState == State.q1 || currentState == State.q2)
            {
                // Previous character was a sign or digit.
                if (Char.IsDigit(ch))
                {
                    // Current character is a digit.
                    toStateQ2(ch - '0');
                }
                else
                {
                    // Current character is not a digit.
                    // Reached a dead state.
                    toStateQd();
                }
            }
        }

        // Return the final result formed with it's sign.
        public int getInteger()
        {
            return sign * result;
        }

        // Get current state.
        public State getState()
        {
            return currentState;
        }
    };
}
