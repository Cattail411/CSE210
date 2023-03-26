using System;
public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _date = DateTime.Now.ToString("MM-dd-yyyy");
    public list<Entry> _entries = new list<Entry>();
    public void DisplayEntry() 
    {
        Consonle.WriteLine($"Date: {_date} Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
}