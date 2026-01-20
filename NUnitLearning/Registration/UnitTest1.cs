namespace Registration;

[TestFixture]
public class Tests
{
    private UserRegistration userRegistration;
    [SetUp]
    public void Setup()
    {
        userRegistration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_WithValidInputs()
    {
        Assert.DoesNotThrow(() =>
            {
                userRegistration.RegisterUser("jaykant", "jaykant@test.com", "secret1");
            });
    }

    [TestCase("")]
        public void RegisterUser_WithInvalidUsername(string username)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                userRegistration.RegisterUser(username, "user@test.com", "secret1");
            });
        }

     [TestCase("")]
        [TestCase("invalidemail")]
        [TestCase("user.com")]
        public void RegisterUser_WithInvalidEmail(string email)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                userRegistration.RegisterUser("user1", email, "secret1");
            });
        }

        [TestCase("")]
        [TestCase("123")]
        [TestCase("abc")]
        public void RegisterUser_WithInvalidPassword(string password)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                userRegistration.RegisterUser("user1", "user@test.com", password);
            });
        }   
}
