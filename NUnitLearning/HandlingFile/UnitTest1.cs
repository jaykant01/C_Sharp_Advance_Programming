namespace HandlingFile;

[TestFixture]
public class Tests {
  private ProcessFile processFile;
  private string testFile;

  [SetUp]
  public void Setup() {
    processFile = new ProcessFile();
    testFile = "testfile.txt";

    if (File.Exists(testFile)) {

      File.Delete(testFile);
    }
  }

  [TearDown]
  public void TearDown() {
    // Cleanup after each test
    if (File.Exists(testFile)) {
      File.Delete(testFile);
    }
  }
  
  [Test]
  public void WriteAndRead_ShouldReturnSameContent() {
    // Arrange
    string content = "Hello NUnit File Test";

    // Act
    processFile.WriteToFile(testFile, content);
    string result = processFile.ReadFromFile(testFile);

    // Assert
    Assert.That(result, Is.EqualTo(content));
  }
  
  [Test]
  public void WriteToFile_ShouldCreateFile() {
    // Arrange
    string content = "File should exist";

    // Act
    processFile.WriteToFile(testFile, content);

    // Assert
    Assert.That(File.Exists(testFile), Is.True);
  }
  
  [Test]
  public void ReadFromFile_WhenFileDoesNotExist_ShouldThrowIOException() {
    // Act & Assert
    Assert.Throws<IOException>(() => {
      processFile.ReadFromFile("nonexistent.txt");
    });
  }
}
