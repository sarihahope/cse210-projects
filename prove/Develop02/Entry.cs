using System;
public class Entry
{
    public string _prompt;
    public string _entryText;
    public string _fullEntry;
    public string _dateEntry;



    public string dateTime()
    {
        DateTime thecurrentTime = DateTime.Now;
        string dateText = thecurrentTime.ToShortDateString();

        return dateText;
    }


    
    
    public string displayFullText ()
    {

        JournalPrompt prompt = new JournalPrompt();
        _prompt = prompt.randomePrompt();
        string date = dateTime();
        Console.WriteLine($"{date} {_prompt}");
        Console.WriteLine();
        _entryText = Console.ReadLine();
        _fullEntry = ($"{date} {_prompt} {_entryText}");
        

        return _fullEntry;

    }

    public void DisplaySomthing()
    {
        Console.WriteLine(dateTime());
        Console.WriteLine();
        Console.WriteLine($"{_prompt}");
        Console.WriteLine();
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }

        
        
    

}