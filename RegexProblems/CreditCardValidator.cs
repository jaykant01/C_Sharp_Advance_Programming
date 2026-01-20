using System.Text.RegularExpressions;
namespace RegexProblems;

public class CreditCardValidator
{
    private static readonly string visaPattern = @"^4\d{15}$";
    private static readonly string masterCardPattern = @"^5\d{15}$";

    public static bool IsValidVisa(string cardNumber)
    {
        return Regex.IsMatch(cardNumber, visaPattern);
    }

    public static bool IsValidMasterCard(string cardNumber)
    {
        return Regex.IsMatch(cardNumber, masterCardPattern);
    }

    public static bool IsValidCreditCard(string cardNumber)
    {
        return IsValidVisa(cardNumber) || IsValidMasterCard(cardNumber);
    }

    public static void RunDemo()
    {
        string[] testCards =
        {
                "4111111111111111", 
                "5111111111111111", 
                "6111111111111111", 
                "411111111111111",  
                "51111111111111112"
            };

        Console.WriteLine("Credit Card Validation Results (Visa & MasterCard):\n");

        foreach (var card in testCards)
        {
            bool isVisa = IsValidVisa(card);
            bool isMaster = IsValidMasterCard(card);
            bool isValid = IsValidCreditCard(card);

            string cardType =
                isVisa ? "Visa" :
                isMaster ? "MasterCard" :
                "Unknown";

            Console.WriteLine($"{card} → {(isValid ? "Valid" : "Invalid")} ({cardType})");
        }
    }
}
