namespace LeetCode.TwoPointers;

// https://leetcode.com/problems/reverse-prefix-of-word/


internal class _2000_ReversePrefixOfWord : LeetCodeBase
{
    public override string Title { get; } = "2000. Reverse Prefix of Word";

    public void Execute(string word, char ch)
    {
        PrintStartMethodInfo();

        var result = ReversePrefix(word, ch);

        Console.WriteLine(result);

        PrintFinishMethodInfo();
    }

    public string ReversePrefix(string word, char ch)
    {
        if (word.Length < 2)
        {
            return word;
        }

        int leftPointer = 0;
        int rightPointer = 0;

        var input = word.ToCharArray();

        foreach (var inputCh in input)
        {
            if (inputCh == ch)
            {
                while (leftPointer < rightPointer)
                {
                    (input[leftPointer], input[rightPointer]) = (input[rightPointer], input[leftPointer]);

                    leftPointer++;
                    rightPointer--;
                }
                break;
            }

            rightPointer++;
        }

        return new string(input);
    }
}
