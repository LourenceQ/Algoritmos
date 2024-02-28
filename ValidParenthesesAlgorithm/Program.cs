namespace ValidParenthesesAlgorithm;

public static class Program
{
    public static void Main(string[] args)
    {

    }
    public static bool IsValid(string s)
    {
        Stack<char> st = new Stack<char>();

        if (string.IsNullOrEmpty(s))
            return false;

        foreach (var item in s.ToCharArray())
        {
            if (item == '(')
            {
                st.Push(')');
            }
            else if (item == '[')
            {
                st.Push(']');
            }
            else if (item == '{')
            {
                st.Push('}');
            }
            else if (st.Count == 0 || st.Pop() != item)
            {
                return false;
            }
        }

        return st.Count == 0;
    }
}
