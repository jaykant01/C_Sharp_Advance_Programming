namespace Lambda_Linq;

public class StringSorter
{
    public static void Run()
    {
        Console.WriteLine("Strings Sorted by Length ");

        List<string> words = new List<string>
        {
             "Apple", "Banana", "Kiwi", "Strawberry", "Mango"
        };

        var sortedWords = words.OrderBy(w => w.Length);

        foreach (var word in sortedWords)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine();
    }
}
