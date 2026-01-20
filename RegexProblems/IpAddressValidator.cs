using System.Text.RegularExpressions;
namespace RegexProblems;

public class IpAddressValidator
{
    private static readonly string pattern =
            @"^((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])\.){3}" +
            @"(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])$";

    public static bool IsValidIpAddress(string ipAddress)
    {
        return Regex.IsMatch(ipAddress, pattern);
    }

    public static void RunDemo()
    {
        string[] testIps =
        {
                "192.168.1.1",     
                "255.255.255.255",
                "0.0.0.0",         
                "256.100.50.25",  
                "192.168.1",       
                "192.168.1.999",   
                "123.045.067.089"  
            };

        Console.WriteLine("IPv4 Address Validation Results:\n");

        foreach (var ip in testIps)
        {
            bool isValid = IsValidIpAddress(ip);
            Console.WriteLine($"{ip} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
