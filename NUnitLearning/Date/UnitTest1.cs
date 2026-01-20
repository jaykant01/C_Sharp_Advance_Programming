namespace Date;

public class Tests
{
    private DateFormatter dateFormatter;

    [SetUp]
    public void Setup()
    {
        dateFormatter = new DateFormatter();
    }

    [TestCase("2026-01-20", "20-01-2026")]
    [TestCase("1990-12-05", "05-12-1990")]
    [TestCase("2000-02-29", "29-02-2000")]
    public void FormatDate_WithValidDate(string input, string expected)
    {
        string result = dateFormatter.FormatDate(input);

        Assert.That(result, Is.EqualTo(expected));
    }


    [TestCase("2026/01/20")]  
    [TestCase("20-01-2026")]
    [TestCase("2026-13-01")]  
    [TestCase("2026-02-30")]  
    [TestCase("")]           
    public void FormatDate_WithInvalidDate(string input)
    {
        Assert.Throws<FormatException>(() =>
        {
            dateFormatter.FormatDate(input);
        });
    }
}
