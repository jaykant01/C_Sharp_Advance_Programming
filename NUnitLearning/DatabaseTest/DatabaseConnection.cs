namespace DatabaseTest;

public class DatabaseConnection
{
    public bool IsConnected {get; set;}

    public void Connect()
    {
        IsConnected = true;
    }

    public void Disconnect()
    {
        IsConnected = false;
    }
}
