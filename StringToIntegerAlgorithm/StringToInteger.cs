namespace StringToIntegerAlgorithm;

public static class StringToInteger
{
    public static int Validate(string s)
    {
        if (s == null || s.Length == 0) return 0;

        int idx = 0;
        while (idx < s.Length && s[idx] == ' ')
            idx++;

        int sign = 1;
        if (idx < s.Length
           && (s[idx] == '-' || s[idx] == '+'))
        {
            if (s[idx] == '-')
                sign = -1;
            idx++;
        }

        int num = 0;
        while (idx < s.Length)
        {
            if (s[idx] >= '0' && s[idx] <= '9')
            {
                if (num > Int32.MaxValue / 10
                  || num == Int32.MaxValue / 10
                  && s[idx] - '0' > Int32.MaxValue % 10)
                {
                    return sign == 1 ?
                        Int32.MaxValue :
                        Int32.MinValue;
                }
                else
                {
                    num = num * 10 + s[idx] - '0';
                    idx++;
                }
            }
            else
            {
                break;
            }
        }

        return sign * num;
    }
}
