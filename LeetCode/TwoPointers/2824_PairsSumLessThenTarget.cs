namespace LeetCode.TwoPointers;

public class _2824_PairsSumLessThenTarget : LeetCodeBase
{
    public override string Title { get; } = "2824. Count Pairs Whose Sum is Less than Target";

    public void Execute(IList<int> nums, int target)
    {
        PrintStartMethodInfo();

        var result = CountPairs(nums, target);

        Console.WriteLine(result);

        PrintFinishMethodInfo();
    }

    private int CountPairs(IList<int> nums, int target)
    {
        // Corner cases
        if (nums.Count == 0 || nums.Count == 1) return 0;
        if (nums.Count == 2)
        {
            var sum = nums[0] + nums[1];

            return sum < target ? 1 : 0;
        }

        int result = 0;

        // Solution
        int leftPointer = 0;
        int rightPointer = 1;

        while (leftPointer < nums.Count - 1)
        {
            if (nums[leftPointer] + nums[rightPointer] < target)
            {
                result++;
            }

            rightPointer++;
            if (rightPointer >= nums.Count)
            {
                leftPointer++;
                rightPointer = leftPointer + 1;
                if (rightPointer >= nums.Count)
                {
                    break;
                }
            }
        }

        return result;
    }
}
