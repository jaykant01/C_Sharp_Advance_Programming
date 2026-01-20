using System.ComponentModel.DataAnnotations;
using System.Runtime;

namespace TestPassword;

public class Tests
{
    private PasswordValidator passwordValidator;

    [SetUp]
    public void Setup()
    {
        passwordValidator = new PasswordValidator();
    }

    [TestCase("Password1")]
    [TestCase("StrongPass9")]
    [TestCase("HelloWorld8")]
    public void IsValid_ReturnTrue(string password)
    {
        bool result = passwordValidator.IsValid(password);
        Assert.That(result, Is.True);
    }

    public void IsValid_ReturnFalse(string password)
    {
        bool result = passwordValidator.IsValid(password);
        Assert.That(result, Is.False);
    }
}
