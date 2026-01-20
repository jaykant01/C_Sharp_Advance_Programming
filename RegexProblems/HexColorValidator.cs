using System.Text.RegularExpressions;
namespace RegexProblems;

public class HexColorValidator
{
    private static readonly string pattern = @"^#[0-9A-Fa-f]{6}$";

    public static bool IsValidHexColor(string colorCode)
    {
        return Regex.IsMatch(colorCode, pattern);
    }

    public static void RunDemo()
    {
        string[] testColors =
        {
                "#FFA500", 
                "#ff4500", 
                "#123",    
                "FFA500",  
                "#GGGGGG"
            };

        Console.WriteLine("Hex Color Code Validation Results:\n");

        foreach (var color in testColors)
        {
            bool isValid = IsValidHexColor(color);
            Console.WriteLine($"{color} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
