using System.Text.RegularExpressions;
namespace RegexProblems;

public class LinkExtractor
{
    private static readonly string pattern = @"https?://[^\s]+";

    public static void ExtractLinks(string text)
    {
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Links:\n");

        if (matches.Count == 0)
        {
            Console.WriteLine("No links found.");
            return;
        }

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public static void RunDemo()
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";

        Console.WriteLine("Input Text:\n");
        Console.WriteLine(text);
        Console.WriteLine();

        ExtractLinks(text);
    }
}
