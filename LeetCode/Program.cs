using LeetCode.TwoPointers;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        Task2824();
    }

    public static void Task2824()
    {
        var task = new _2824_PairsSumLessThenTarget();

        //var nums = new List<int>() { -1, 1, 2, 3, 1 };
        var nums = new List<int>() { -6, 2, 5, -2, -7, -1, 3 };
        int target = -2;

        task.Execute(nums, target);
    }
}
