using System;
using System.IO;

public class Journal
    {
        public static List<Entry>_entries = new List<Entry>();



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

    public void LoadJournal(string filename) {
        if (File.Exists(filename)) {
            _entries = new List<Entry>();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 3) {
                string _prompt = lines[i];
                string _response = lines[i+1];
                //DateTime date = DateTime.Parse(lines[i+2]);
                Entry entry = new Entry(_prompt, _response);
                _entries.Add(entry);
            }
            Console.WriteLine("Journal loaded from " + filename);
        } else {
            Console.WriteLine("File not found.");
        }
    }

    public void SaveJournal(string filename) {
        List<string> lines = new List<string>();
        for (int i = 0; i < _entries.Count; i++) {
            Entry entry = _entries[i];
            lines.Add(entry._prompt);
            lines.Add(entry._entryText);
            //lines.Add(entry.date.ToString());
        }
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved to" + filename);
    }
}
