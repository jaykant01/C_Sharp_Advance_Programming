using System;
using System.Collections.Generic;
namespace Lambda_Linq;

public class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        if (x == null || y == null) return 0;

        // Sort by Marks descending
        int marksComparison = y.Marks.CompareTo(x.Marks);
        if (marksComparison != 0)
            return marksComparison;

        // If marks are equal, sort by Name ascending
        return x.Name.CompareTo(y.Name);
    }
}
