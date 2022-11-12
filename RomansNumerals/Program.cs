using System;
using System.Collections.Generic;

namespace RomansNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInt("MCMXCIV");
            
        }

        static public int RomanToInt(string s)
        {
            char[] arr = s.ToCharArray();

            Dictionary<char, int> romans = new Dictionary<char, int>();
            romans.Add('I', 1);
            romans.Add('V', 5);
            romans.Add('X', 10);
            romans.Add('L', 50);
            romans.Add('C', 100);
            romans.Add('D', 500);
            romans.Add('M', 1000);

            int sum = 0;

            int len = s.Length;


            for (int i = 0; i < len - 1; i++)
            {
                if (romans[arr[i + 1]] <= romans[arr[i]])
                {
                    sum = sum + romans[arr[i]];
                }
                else
                {
                    sum = sum - romans[arr[i]];
                }
            }
            return sum + romans[arr[len - 1]];
        }
    }
}
