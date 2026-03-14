using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
  private List<Entry> entries = new List<Entry>();

  public void AddEntry(string prompt, string response)
  {
    Entry entry = new Entry(prompt, response);
    entries.Add(entry);
  }

  public void DisplayEntries()
  {
    foreach (Entry entry in entries)
    {
      Console.WriteLine($"{entry}");
    }
  }

  public int EntriesCount()
  {
      return entries.Count;
  }

  public void SaveToFile(string fileName)
  {
    using (StreamWriter writer = new StreamWriter(fileName))
    {
      foreach (Entry entry in entries)
      {
        writer.WriteLine($"Date: {entry.Date}");
        writer.WriteLine($"{entry.Prompt}");
        writer.WriteLine($"> {entry.Response}\n");
      }
    }
  }

  public void LoadFromFile(string fileName)
  {
    entries.Clear();
    
      using (StreamReader reader = new StreamReader(fileName))
      {
        string line;
        string currentPrompt = null;
        string currentResponse = null;
        DateTime currentDate = DateTime.MinValue;

        while ((line = reader.ReadLine()) != null)
        {
          if (line.StartsWith("Date: "))
          {
            currentDate = DateTime.Parse(line.Substring("Date: ".Length));
          }
          else if (line.StartsWith("Prompt: "))
          {
            currentPrompt = line.Substring("Prompt: ".Length);
          }
          else if (line.StartsWith("> "))
          {
            currentResponse = line.Substring("> ".Length);
            entries.Add(new Entry(currentPrompt, currentResponse)
            {
              Date = currentDate,
              Prompt = currentPrompt,
              Response = currentResponse
            });
          }
        }
      }
    

  }
}