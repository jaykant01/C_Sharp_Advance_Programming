namespace Performances;

public class PerformancesTests
{
    private TaskUtils taskUtils;
    [SetUp]
    public void Setup()
    {
        taskUtils = new TaskUtils();
    }

    [Test]
     [Timeout(2000)]
    public void Test1()
    {
        string result = taskUtils.LongRunningTask();

        Assert.That(result, Is.EqualTo("Completed"));
    }
}
