using System.Globalization;
namespace Date;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (string.IsNullOrWhiteSpace(inputDate))
        {
            throw new FormatException("Input date is null or empty.");
        }

        if (!DateTime.TryParseExact(
                    inputDate,
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime date))
            {
                throw new FormatException("Invalid date format. Expected yyyy-MM-dd.");
            }
            
            return date.ToString("dd-MM-yyyy");
    }
}
