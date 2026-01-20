using System.Text.RegularExpressions;
namespace RegexProblems;

public class EmailExtractor
{
    private static readonly string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

    public static void ExtractEmails(string text)
    {
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Email Addresses:\n");

        if (matches.Count == 0)
        {
            Console.WriteLine("No email addresses found.");
            return;
        }

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public static void RunDemo()
    {
        string text = "Contact us at support@example.com and info@company.org";

        Console.WriteLine("Input Text:\n");
        Console.WriteLine(text);
        Console.WriteLine();

        ExtractEmails(text);
    }
}
