public class SolutionOptimized
{
    public int GetMaximumGenerated(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }

        Span<int> nums = stackalloc int[n + 1];
        nums[1] = 1;
        int _max = 1;

        for (int index = 2; index < n + 1; index++)
        {
            if ((index & 1) == 0)
            // "index" is even
            {
                nums[index] = nums[index >> 1];
            }
            else
            // "index" is odd
            {
                int evenIndex = (index - 1) >> 1;
                int oddIndex = evenIndex + 1;

                int value = nums[evenIndex] + nums[oddIndex];
                nums[index] = value;

                if (value > _max)
                {
                    _max = value;
                }
            }
        }

        return _max;
    }
}