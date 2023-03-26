public class Mindfulness
{
    private string choice_message;
    private string _activity;

    public Mindfulness(string DisplayWelcomeMessage, string activity)
    {
        DisplayWelcomeMessage = DisplayWelcomeMessage;
        activity = activity;
        Console.WriteLine("Get ready...");
    }


    public string Welcome()
    {
        return Welcome;
    }

    public string activity()
    {
        return activity;
    }

    public string choice_message()
    {
        return Welcome + " - " + activity;
    }
}