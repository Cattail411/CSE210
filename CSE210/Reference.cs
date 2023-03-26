using System;

public class Reference
{
    public string _name;

    
    public List<Word> _jobs = new List<Word>();

    public void Display()
    {
        Console.WriteLine($"Alma 37: 6-7");
        Console.WriteLine("Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.");
        Console.WriteLine("And the Lord God doth work by ameans to bring about his great and eternal purposes; and by very bsmall means the Lord doth confound the wise and bringeth about the salvation of many souls.");

        
        foreach (Word word in _words)
        {
            
            word.Display();
        }
    }
}