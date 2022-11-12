using System;

namespace DeleteOperationForTwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string w1 = "sea";
            string w2 = "eat";
            Solution.MinDistance(w1, w2);

            var res  = Solution2.MinDistance(w1, w2);
            System.Console.WriteLine(res);
            

        }
    }

    public static class Solution
    {
        public static int MinDistance(string word1, string word2)
        {
            int[] dp = new int[word2.Length + 1]; // 3

            for (int i = 0; i <= word1.Length; i++) // 3; i=0
            {
                int[] temp = new int[word2.Length + 1]; // 4;

                for (int j = 0; j <= word2.Length; j++) // 3; j=2
                {
                    if (i == 0 || j == 0) //
                        temp[j] = i + j;   // temp[2] = 0+2 
                    else if (word1[i - 1] == word2[j - 1]) //
                        temp[j] = dp[j - 1];
                    else
                        temp[j] = 1 + Math.Min(dp[j], temp[j - 1]); // 1

                }
                dp = temp;
            }

            return dp[word2.Length];

        }
    }

    public static class Solution2
    {
        public static int MinDistance(string s1, string s2)
        {
            int m = s1.Length, n = s2.Length;
            int[,] dp = new int[m+1, n+1];
            for(int i=1; i<=m; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    if(s2[j-1] == s1[i-1])
                        dp[i,j] = dp[i-1, j-1] + 1;
                    else
                        dp[i,j] = Math.Max(dp[i-1,j], dp[i, j-1]);
                }
            }

            return m + n -2 * dp[m,n];
        }
    }
}
