namespace DatabaseTest;

[TestFixture]
public class Tests
{
    private DatabaseConnection db;

    [SetUp]
    public void Setup()
    {
        db = new DatabaseConnection();
        db.Connect();
    }

    [TearDown]
    public void TearDown()
    {
        db.Disconnect();
    }

    [Test]
    public void Connect_Db()
    {
        bool result = db.IsConnected;

        Assert.That(result, Is.True);
    }

    [Test]
    public void Disconnect_Db()
    {
        db.Disconnect();

        Assert.That(db.IsConnected, Is.False);
    }
}
