namespace ListOperations;

[TestFixture]
public class ListOperationsTests
{
    private ListManager listManager;

    [SetUp]
    public void Setup()
    {
        listManager = new ListManager();
    }

    [Test]
    public void AddElement()
    {
        // Arrange
        var list = new List<int> {1, 3};

        // Act
        var result = listManager.AddElement(list, 2);

        // Assert
        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result, Does.Contain(2));
    }

    [Test]
    public void RemoveElement()
    {
        // Arrange
        var list = new List<int> {1, 2, 3};
        // Act
        var result = listManager.RemoveElement(list, 2);
        // Assert
        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result, Does.Not.Contain(2));
    }

    [Test]
    public void GetSize()
    {
        var list = new List<int> {10, 20, 30};

        int size = listManager.GetSize(list);

        Assert.That(size, Is.EqualTo(3));
    }

}
