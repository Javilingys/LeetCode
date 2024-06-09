using LeetCode.TwoPointers;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        #region Two Pointers
        // Easy

        //Task2824();
        //Task2000();
        //Task2367();
        //Task2108();
        Task557();

        #endregion

    }

    public static void Task2824()
    {
        var task = new _2824_PairsSumLessThenTarget();

        //var nums = new List<int>() { -1, 1, 2, 3, 1 };
        var nums = new List<int>() { -6, 2, 5, -2, -7, -1, 3 };
        int target = -2;

        task.Execute(nums, target);
    }

    public static void Task2000()
    {
        var task = new _2000_ReversePrefixOfWord();

        string word = "abcdefd";
        char ch = 'd';

        task.Execute(word, ch);
    }

    public static void Task2367()
    {
        var task = new _2367_NumberOfArithmeticTriplets();

        var nums = new int[] { 0, 1, 4, 6, 7, 10 };
        var diff = 3;

        task.Execute(nums, diff);
    }

    public static void Task2108()
    {
        var task = new _2108_FindFirstPalindromicStringInTheArray();

        var words = new string[] { "abc", "car", "ada", "racecar", "cool" };

        task.Execute(words);
    }    
    
    public static void Task557()
    {
        var task = new _557_ReverseWordsInAStringIII();

        var words = "Let's take LeetCode contest";

        task.Execute(words);
    }
}
