namespace Performances;

public class TaskUtils
{
    public string LongRunningTask()
        {
            Thread.Sleep(1000);
            return "Completed";
        }
}
