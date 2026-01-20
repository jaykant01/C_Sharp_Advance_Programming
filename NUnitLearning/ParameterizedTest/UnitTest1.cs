namespace ParameterizedTest;

[TestFixture]
public class Tests
{
    private Parameters parameters;
    [SetUp]
    public void Setup()
    {
        parameters = new Parameters();
    }

    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven(int number, bool expected)
    {
        bool result = parameters.IsEven(number);

        Assert.That(result, Is.EqualTo(expected));
    }

}
