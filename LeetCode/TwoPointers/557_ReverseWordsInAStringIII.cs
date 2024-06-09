namespace LeetCode.TwoPointers;

// https://leetcode.com/problems/reverse-words-in-a-string-iii/

public class _557_ReverseWordsInAStringIII : LeetCodeBase
{
    public override string Title { get; } = "557. Reverse Words in a String III";

    public void Execute(string s)
    {
        PrintStartMethodInfo();

        var result = ReverseWords(s);

        Console.WriteLine($"Result is: {result}");

        PrintFinishMethodInfo();
    }

    public string ReverseWords(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = RevertString(words[i]);
        }

        return string.Join(' ', words);
    }

    private string RevertString(string s)
    {
        var chrs = s.ToCharArray();

        int leftPtr = 0;
        int rightPtr = s.Length - 1;

        while (leftPtr < rightPtr)
        {
            (chrs[leftPtr], chrs[rightPtr]) = (chrs[rightPtr], chrs[leftPtr]);

            leftPtr++;
            rightPtr--;
        }

        return new string(chrs);
    }
}
