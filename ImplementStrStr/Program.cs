using System;

namespace ImplementStrStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string haystack = "hello";
            string needle = "ll";
            var res = StrStr(haystack, needle);

            System.Console.WriteLine(res);

        }

        public static int StrStr(string haystack, string needle)
        {
            int i = 0,
                j = 0;
            int[] lps = BuildLPS(needle);

            while (i < haystack.Length && j < needle.Length)
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if (j > 0)
                        j = lps[j - 1];
                    else
                        i++;
                }

            return j == needle.Length ? i - j : -1;
        }

        private static int[] BuildLPS(string needle)
        {
            int[] lps = new int[needle.Length];
            int i = 0;

            for (int j = 1; j < needle.Length;)
                if (needle[i] == needle[j])
                {
                    lps[j] = i + 1;

                    i++;
                    j++;
                }
                else
                {
                    if (i > 0)
                        i = lps[i - 1];
                    else
                        j++;
                }

            return lps;
        }
    }
}
