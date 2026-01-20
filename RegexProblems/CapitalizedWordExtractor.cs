using System.Text.RegularExpressions;
namespace RegexProblems;

public class CapitalizedWordExtractor
{
    private static readonly string pattern = @"\b[A-Z][a-z]*\b";

    public static void ExtractCapitalizedWords(string text)
    {
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Capitalized Words:\n");

        if (matches.Count == 0)
        {
            Console.WriteLine("No capitalized words found.");
            return;
        }

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public static void RunDemo()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        Console.WriteLine("Input Text:\n");
        Console.WriteLine(text);
        Console.WriteLine();

        ExtractCapitalizedWords(text);
    }
}
