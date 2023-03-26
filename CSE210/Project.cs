using System;
using System.Collections.Generic;
using System.IO;

internal class NewBaseType
{
    
    static void Main(string[] args)
    {
        bool exitProject = false;
        Journal journal1 = newJournal();
        List<string> promptList = new List<string>()
        {
            "What was your happy moment for today?",
            "What made you grateful?",
            "If you could change something that happened today, what would it be?"
        };
    Console.WriteLine("Welcome to the Journal Program!");
    static string UserChoice()
    {
        Console.WriteLine("Please choose one of the following:");
        Console.WriteLine("1: New Entry");
        Console.WriteLine("2: Display Entries");
        Console.WriteLine("3: Load");
        Console.WriteLine("4: Save to Folder");
        Console.WriteLine("5: Quit");
        Console.WriteLine("What would you like to do?");
        
        string choice = Console.ReadLine();
        while(!exitProgram)
        {
            string choiceSelected = UserChoice();
            switch(choiceSelected)
            {
                case "1":
                Random random = new Random();
                int num = random.Next(0, 6);
                NewEntry newEntry = new NewEntry();
                Entry._prompt = promptList[num];
                Console.WriteLine(Entry._prompt);
                Console.Write("Your response: ");
                string userResponse = Console.ReadLine();
                Entry._response = userResponse;
                journal1._entries.Add(Entry);
                break;

                case "2":
                journal1.DisplayJournal();
                break;

                case "3":
                Console.Write("File Name: ");
                string loadFileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(loadFileName);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                break;

                case "4":
                Console.Write("Save as: ");
                string saveFileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter())
                {
                    foreach (Entry entry in journal1._entries)
                    {
                        outputFile.WriteLine($"Date: {_date} Prompt: {_prompt}");
                        outputFile.WriteLine($"Response: {_response}");
                    }

                }
                break;

                case "5":
                    exitProject = true;
                break;

                default:
                    Console.WriteLine("Please choose a valid option");
                break;
            } 
        }
    }
    }
}