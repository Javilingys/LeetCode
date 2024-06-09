using System.Diagnostics;

namespace LeetCode;

public abstract class LeetCodeBase
{
    public abstract string Title { get; }
    private Stopwatch _stopwatch { get; }

    public LeetCodeBase()
    {
        _stopwatch = new Stopwatch();
    }

    public void PrintStartMethodInfo()
    {
        _stopwatch.Start();

        Console.WriteLine($"Leet Code Task \"{Title}\" started.");
        Console.WriteLine();
    }

    public void PrintFinishMethodInfo()
    {
        _stopwatch.Stop();

        Console.WriteLine($"Leet Code Task \"{Title}\" finished in {_stopwatch.ElapsedMilliseconds}ms");
    }
}