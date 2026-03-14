using System;

class Entry
{
  public string Prompt { get; set; }
  public string Response { get; set; }
  public DateTime Date { get; set; }

  public Entry(string prompt, string response)
  {
    Prompt = prompt;
    Response = response;
    Date = DateTime.Now;

  }

  public string Display(string Date,string Prompt,string response)
  {
      string Entry = $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
      return Entry;
  }
}