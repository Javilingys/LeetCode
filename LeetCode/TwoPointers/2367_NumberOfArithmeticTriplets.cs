namespace LeetCode.TwoPointers;

// https://leetcode.com/problems/number-of-arithmetic-triplets/description/

internal class _2367_NumberOfArithmeticTriplets : LeetCodeBase
{
    public override string Title { get; } = "2367. Number of Arithmetic Triplets";

    public void Execute(int[] nums, int diff)
    {
        PrintStartMethodInfo();

        var result = ArithmeticTriplets(nums, diff);

        Console.WriteLine($"Result is: {result}");

        PrintFinishMethodInfo();
    }

    public int ArithmeticTriplets(int[] nums, int diff)
    {
        HashSet<int> s = new HashSet<int>(nums);

        int r = 0;

        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (s.Contains(nums[i] - diff) && s.Contains(nums[i] + diff))
            {
                r++;
            }
        }

        return r;
    }
}
