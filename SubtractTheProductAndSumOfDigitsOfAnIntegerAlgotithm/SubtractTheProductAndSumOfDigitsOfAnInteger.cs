namespace SubtractTheProductAndSumOfDigitsOfAnIntegerAlgotithm;

public static class SubtractTheProductAndSumOfDigitsOfAnInteger
{
    public static int Validate(int n)
    {
        int mult = 1, sum = 0;

        List<int> digits = [];

        if (n == 0) return 0;

        while (n > 0)
        {
            var digit = n % 10;
            n /= 10;
            digits.Add(digit);
        }

        for (int x = 0; x < digits.Count; x++)
        {
            mult *= digits[x];
            sum += digits[x];
        }

        return mult - sum;
    }
}
