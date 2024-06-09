namespace LeetCode.TwoPointers;

// https://leetcode.com/problems/find-first-palindromic-string-in-the-array/

public class _2108_FindFirstPalindromicStringInTheArray : LeetCodeBase
{
    public override string Title { get; } = "2108. Find First Palindromic String in the Array";

    public void Execute(string[] words)
    {
        PrintStartMethodInfo();

        var result = FirstPalindrome(words);

        Console.WriteLine($"Result is: {result}");

        PrintFinishMethodInfo();
    }

    private string FirstPalindrome(string[] words)
    {
        if (words.Length == 0)
        {
            return "";
        }

        string result = "";

        foreach (var word in words)
        {
            if (IsPalindrome(word))
            {
                result = word;
                break;
            }
        }

        return result;
    }

    private bool IsPalindrome(string str)
    {
        int leftPtr = 0;
        int rightPtr = str.Length - 1;

        while (leftPtr < rightPtr)
        {
            if (str[leftPtr++] != str[rightPtr--])
            {
                return false;
            }
        }

        return true;
    }
}
