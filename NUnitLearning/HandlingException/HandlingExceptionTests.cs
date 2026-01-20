namespace HandlingException;

[TestFixture]
public class HandlingExceptionTests
{   
    private DivideZero divideZero;

    [SetUp]
    public void Setup()
    {
        divideZero = new DivideZero();
    }

    [Test]
    public void DivideZero()
    {
        // Assert & Act
        Assert.Throws<ArithmeticException>(() => divideZero.Divide(10, 0));
    }
}
