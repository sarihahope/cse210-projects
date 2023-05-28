using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Scritpure.AllTogether();

        word scripture = new word("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Console.Clear();
        word.DisplayScripture();


        while (true)
        {
            Console.WriteLine("Press enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {

                Console.Clear();
                word.HideWord();
                word.DisplayScripture();


                if (word.AllWordsHidden())
                {
                    break;
                }
            }
        }
    }
}
