using System.Collections.Generic;
namespace ListOperations;

public class ListManager
{
    public List<int> AddElement(List<int> list, int element)
    {
        list.Add(element);
        return list;
    }

    public List<int> RemoveElement(List<int> list, int element)
    {
        list.Remove(element);
        return list;
    }

    public int GetSize(List<int> list)
    {
        return list.Count;
    }
}
