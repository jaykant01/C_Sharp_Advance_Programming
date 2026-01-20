using System.Text.RegularExpressions;
namespace RegexProblems;

public class SpaceNormalizer
{
    private static readonly string pattern = @"\s+";

    public static string NormalizeSpaces(string input)
    {
        return Regex.Replace(input, pattern, " ");
    }

    public static void RunDemo()
    {
        string input = "This   is   an    example   with   multiple   spaces.";

        Console.WriteLine("Original Text:\n");
        Console.WriteLine(input);
        Console.WriteLine();

        string normalized = NormalizeSpaces(input);

        Console.WriteLine("After Replacing Multiple Spaces with Single Space:\n");
        Console.WriteLine(normalized);
    }
}
