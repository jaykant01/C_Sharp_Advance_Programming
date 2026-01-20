using System.Text.RegularExpressions;
namespace RegexProblems;

public class SsnValidator
{
    private static readonly string pattern = @"\b\d{3}-\d{2}-\d{4}\b";

    public static bool IsValidSsn(string ssn)
    {
        return Regex.IsMatch(ssn, pattern);
    }

    public static void ExtractAndValidateSsn(string text)
    {
        Match match = Regex.Match(text, pattern);

        Console.WriteLine("Input Text:\n");
        Console.WriteLine(text);
        Console.WriteLine();

        if (match.Success)
        {
            string ssn = match.Value;
            bool isValid = IsValidSsn(ssn);

            Console.WriteLine($"Extracted SSN: {ssn}");
            Console.WriteLine($"Validation Result: {(isValid ? "Valid" : "Invalid")}");
        }
        else
        {
            Console.WriteLine("No valid SSN found in the text.");
        }
    }

    public static void RunDemo()
    {
        string text1 = "My SSN is 123-45-6789.";
        string text2 = "My SSN is 123456789.";

        Console.WriteLine("Example 1");
        ExtractAndValidateSsn(text1);

        Console.WriteLine("\nExample 2");
        ExtractAndValidateSsn(text2);
    }
}
