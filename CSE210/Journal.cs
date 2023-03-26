using System;
using System.Collections.Generic;

public class NewBaseType
{
}

public class Journal : NewBaseType
{
    public void DisplayJournal()
    {
        foreach (Entry entries in _entries)
        {
            entry.DisplayEntry();
        }
    }
}
