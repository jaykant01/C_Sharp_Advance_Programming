using System.Text.RegularExpressions;
namespace RegexProblems;

public class DateExtractor
{
    private static readonly string pattern =
            @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}\b";

    public static void ExtractDates(string text)
    {
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Dates (dd/mm/yyyy):\n");

        if (matches.Count == 0)
        {
            Console.WriteLine("No dates found.");
            return;
        }

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    
    public static void RunDemo()
    {
        string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";

        Console.WriteLine("Input Text:\n");
        Console.WriteLine(text);
        Console.WriteLine();

        ExtractDates(text);
    }
}
