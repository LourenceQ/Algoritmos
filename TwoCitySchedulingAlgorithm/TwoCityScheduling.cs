namespace TwoCitySchedulingAlgorithm;
public static class TwoCityScheduling
{
    public static int Validate(int[][] costs)
    {
        var list = costs.OrderByDescending(c => Math.Abs(c[0] - c[1])).ToList();

        int res = 0, a = 0, b = 0;

        foreach (var l in list)
        {
            if (a == costs.Length / 2) res += l[1];
            else if (b == costs.Length / 2) res += l[0];
            else
            {
                res += Math.Min(l[0], l[1]);

                if (l[0] < l[1])
                    a++;
                else
                    b++;
            }
        }

        return res;
    }
}
