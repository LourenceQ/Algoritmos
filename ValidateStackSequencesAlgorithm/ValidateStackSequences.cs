namespace ValidateStackSequencesAlgorithm;

public static class ValidateStackSequences
{
    public static bool Validate(int[] pushed, int[] popped)
    {
        var pushedLen = pushed.Length;

        int push = 0, pop = 0;

        var stack = new Stack<int>();

        while (push < pushedLen || pop < pushedLen)
        {
            if (stack.Count == 0)
            {
                if (push >= pushedLen)
                {
                    break;
                }
                stack.Push(pushed[push++]);
            }
            else if (popped[pop] == stack.Peek())
            {
                stack.Pop();
                pop++;
            }
            else if (push < pushedLen)
            {
                stack.Push(pushed[push++]);
            }
            else
            {
                break;
            }
        }

        return stack.Count == 0;
    }
}
