namespace StringUtility;

[TestFixture]
public class StringUtilityTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Reverse_InputString_ReturnsReversed()
    {
        string input = "hello";

        string result = StringUtils.Reverse(input);

        Assert.AreEqual("olleh", result);
    }

    [TestCase("madam", true)]
    [TestCase("racecar", true)]
    [TestCase("hello", false)]
    public void IsPalindrome_ChecksCorrectly(string input, bool expected)
    {
        bool result = StringUtils.IsPalindrome(input);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void ToUpperCase_InputString_ReturnsUpperCase()
    {
        string input = "hello world";

        string result = StringUtils.ToUpperCase(input);

        Assert.AreEqual("HELLO WORLD", result);
    }
}
