using System.IO;

namespace HandlingFile;

public class ProcessFile
{
    public void WriteToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    public string ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            throw new IOException("File not found");
        }

        return File.ReadAllText(filename);
    }
}
