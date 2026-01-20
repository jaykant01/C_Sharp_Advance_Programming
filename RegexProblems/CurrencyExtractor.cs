using System.Text.RegularExpressions;
namespace RegexProblems;

public class CurrencyExtractor
{
    private static readonly string pattern = @"\$?\s*\d+(\.\d{2})?";

    public static void ExtractCurrencyValues(string text)
    {
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Currency Values:\n");

        if (matches.Count == 0)
        {
            Console.WriteLine("No currency values found.");
            return;
        }

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.Trim());
        }
    }

    public static void RunDemo()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";

        Console.WriteLine("Input Text:\n");
        Console.WriteLine(text);
        Console.WriteLine();

        ExtractCurrencyValues(text);
    }
}
