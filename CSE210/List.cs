public class List : Mindfulness
{
    private string choice_message;
    private string _problems;

    
    public List(string choice_message, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        
        _list = List;
        _problems = problems;
    }

    public string GetList()
    {
        return $"Section {_list} Problems {_problems}";
    }
}