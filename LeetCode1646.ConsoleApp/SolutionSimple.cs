public class SolutionSimple
{
    private int _max = 0;

    public int GetMaximumGenerated(int n)
    {
        List<int> nums = this.GenerateArray(n);

        return _max;
    }

    private List<int> GenerateArray(int n)
    {
        List<int> nums = new List<int>(capacity: n + 1);

        for (int i = 0; i < n + 1; i++)
        {
            int value = 0;
            if (i == 0)
            {
                value = 0;
            }
            else if (i == 1)
            {
                value = 1;
            }
            else if (i.IsEven())
            {
                value = nums[i / 2];
            }
            else
            {
                int evenIndex = (i - 1) / 2;
                int oddIndex = evenIndex + 1;
                value = nums[evenIndex] + nums[oddIndex];
            }

            nums.Add(value);

            this._max = Math.Max(this._max, value);
        }

        return nums;
    }
}

public static class IntExtensions
{
    public static bool IsEven(this int value)
    {
        if ((value & 1) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}