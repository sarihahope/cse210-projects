using System;


public class JournalPrompt
{
    public List<string> _prompt = new List<string>()
    {
        "What was one postive thing about your day? ",
        "What is something you learned today",
        "How did you help someone today? ",
        "How have your been uplifted today? ",
        "How have you been blessed today? ",
    };

    public string randomePrompt()
    {
        var random = new Random();
        int index = random.Next(_prompt.Count);
        string prompt = ($"{_prompt[index]}");

        return prompt;

    }
}
        
    
        