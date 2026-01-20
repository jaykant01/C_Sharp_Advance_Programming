using System.Text.RegularExpressions;
namespace RegexProblems;

public class UsernameValidator
{
    private static readonly string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";

    public static bool IsValidUsername(string username)
    {
        return Regex.IsMatch(username, pattern);
    }

    public static void RunDemo()
    {
        string[] testUsernames =
        {
                "user_123",    
                "123user",      
                "us",           
                "Valid_User1", 
                "A_very_long_username" 
            };

        Console.WriteLine("Username Validation Results:\n");

        foreach (var username in testUsernames)
        {
            bool isValid = IsValidUsername(username);
            Console.WriteLine($"{username} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
