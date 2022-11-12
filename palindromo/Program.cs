using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // IsPalindrome(99888899);
            IsPalindrome2(99888899);
        }

        static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                System.Console.WriteLine("é palindromo");
                return false;
            }

            else
            {
                string y = x.ToString();

                char[] arr = y.ToCharArray();
                Array.Reverse(arr);

                y = new string(arr);
                System.Console.WriteLine(y);

                double z = double.Parse(y);

                if (z == x)
                {
                    Console.WriteLine("é palindromo");
                    return true;
                }
            }
            System.Console.WriteLine("não é palindromo");
            return false;
        }

        public static bool IsPalindrome2(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int revertedNum = 0;
            while (x > revertedNum)
            {
                revertedNum = revertedNum * 10 + x % 10;
                x /= 10;
            }
            return x == revertedNum || x == revertedNum/10;
        }
    }
}
