namespace StringUtility;

public class StringUtils
{
    public static string Reverse(string str)
    {
        if (str == null) return null;
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static bool IsPalindrome(string str)
    {
        if (str == null) return false;
        string reversed = Reverse(str);
        return str == reversed;
    }

    public static string ToUpperCase(string str)
    {
        if (str == null) return null;
        return str.ToUpper();
    }
}
