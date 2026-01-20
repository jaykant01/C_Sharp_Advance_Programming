using System.Text.RegularExpressions;
namespace RegexProblems;

public class BadWordCensor
{
    private static readonly string[] badWords = { "damn", "stupid" };

    private static readonly string pattern =
        @"\b(" + string.Join("|", badWords) + @")\b";

    public static string CensorText(string input)
    {
        return Regex.Replace(input, pattern, "****", RegexOptions.IgnoreCase);
    }

    public static void RunDemo()
    {
        string input = "This is a damn bad example with some stupid words.";

        Console.WriteLine("Original Text:\n");
        Console.WriteLine(input);
        Console.WriteLine();

        string censored = CensorText(input);

        Console.WriteLine("After Censoring Bad Words:\n");
        Console.WriteLine(censored);
    }
}
