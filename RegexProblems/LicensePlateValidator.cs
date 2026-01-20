using System.Text.RegularExpressions;
namespace RegexProblems;

public class LicensePlateValidator
{
    private static readonly string pattern = @"^[A-Z]{2}[0-9]{4}$";

    public static bool IsValidLicensePlate(string plateNumber)
    {
        return Regex.IsMatch(plateNumber, pattern);
    }

    // All demo/testing logic here
    public static void RunDemo()
    {
        string[] testPlates =
        {
                "AB1234",  
                "A12345",  
                "ab1234",  
                "ABC123",  
                "XY9876"   
            };

        Console.WriteLine("License Plate Validation Results:\n");

        foreach (var plate in testPlates)
        {
            bool isValid = IsValidLicensePlate(plate);
            Console.WriteLine($"{plate} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
