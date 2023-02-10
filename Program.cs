using Exercises.LeetCode;
using LeetCode;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string?> a = new() {"asd", "aww",
        "as", null, "olol"};
        int?[] b = new int?[] { 1, 2, 3, null, 5, 6 };
        Console.WriteLine(a.ValuesAsString());
        Console.WriteLine(b.ValuesAsString());
    }
}
