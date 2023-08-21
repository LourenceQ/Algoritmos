using System.Reflection.Metadata.Ecma335;

namespace MainProj;

public static class Program
{
    public static void Main (string[] args)
    {

    }

    public static bool RepeatedSubstringPattern(string s) {
        int n = s.Length;
        for (int i = 1; i <= n / 2; i++) {
            if (n % i == 0) {
                string substring = s.Substring(0, i);
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int j = 0; j < n / i; j++) {
                    builder.Append(substring);
                }
                if (builder.ToString() == s) return true;
            }
        }
        return false;
    }
}