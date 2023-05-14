using System;
using System.IO;

public class Journal
    {
        public List<Entry>_entries = new List<Entry>();



        public void journalAdd()
        {

                Entry entry = new Entry();
                entry._fullEntry = entry.displayFullText();
                _entries.Add(entry);
        }


        public void DisplayEntry()
        {
            Console.WriteLine();
            Console.WriteLine("Here are your entries: ");
            Console.WriteLine();

            foreach (var entry in _entries)
            {
                entry.DisplaySomthing();
            }
        }

        public void saveFile()
        {

                Console.WriteLine("Saving to file..... ");
                string _fileName = "entries.txt";

                using (StreamWriter outputfile = new StreamWriter(_fileName))
                {
                        foreach (var Entry in _entries)
                        {
                            outputfile.WriteLine($"{_entries}");
                        }
                }
        }


        public void loadFile()
        {
                Console.WriteLine("Loading from List.....");
                 string _fileName = "entries.csv";
                 string[] lines = System.IO.File.ReadAllLines(_fileName);

                 foreach (string line in lines)
                 {
                    string[] parts = line.Split(",");

                    string dateTime = parts[0];
                    string JournalPrompt = parts[1];
                    string journalEntry = parts[2];

                 }

        }
    }
