using System;
// for my creativity i added a way for the user to select what type of prompt they wanted, they way if they hadnt journaled in a week they could 
// choose a prompt that would let them get caught up on the week, or they could choose no prompt
class Program
{
  static void Main(string[] args)
  {
    Journal journal = new Journal();
    bool keepRunning = true;

    while (keepRunning)
    {
      Console.WriteLine("Welcome to the Journal Program of Keyarra Bassett");
      Console.WriteLine("Please select an option 1-5");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Save");
      Console.WriteLine("4. Load");
      Console.WriteLine("5. Exit");

      Console.Write("What would you like to do? ");
      string choice = Console.ReadLine();


      // i tried to do an if and else if chain, but it wasnt working, so i googled other ways to do it
      // and switch was recommended

      switch (choice)
      {
        case "1":

          Console.WriteLine("What type of prompt would you like?");
          Console.WriteLine("1. Daily Prompt");
          Console.WriteLine("2. Weekly Prompt");
          Console.WriteLine("3. Spiritual Prompt");
          Console.WriteLine("4. No prompt");
          Console.Write("Please select a Prompt 1-3 ");
          string selectedprompt = Console.ReadLine();

          switch (selectedprompt)
          {
            case "1":
              string dailyPrompt = PromptGenerator.GetRandomDailyPrompt();
              Console.WriteLine($"{dailyPrompt}");
              Console.Write(">");
              string dailyResponse = Console.ReadLine();
              journal.AddEntry(dailyPrompt, dailyResponse);

            break;
            
            case "2":
              string weeklyprompt = PromptGenerator.GetRandomWeeklyPrompt();
              Console.WriteLine($"{weeklyprompt}");
              Console.Write(">");
              string WeeklyResponse = Console.ReadLine();
              journal.AddEntry(weeklyprompt, WeeklyResponse);

            break;

            case "3":
              string Spiritualprompt = PromptGenerator.GetRandomSpiritualPrompt();
              Console.WriteLine($"{Spiritualprompt}");
              Console.Write(">");
              string SpiritualResponse = Console.ReadLine();
              journal.AddEntry(Spiritualprompt, SpiritualResponse);

            break;

            case "4":
              string prompt = "No Prompt";
              Console.WriteLine($"Write your Journal Entry:");
              Console.Write(">");
              string Response = Console.ReadLine();
              journal.AddEntry(prompt, Response);

            break;

            default:
              Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
              break;
              
          }

          break;


        case "2":
          if (journal.EntriesCount() == 0)
          {
              Console.WriteLine("The journal is currently empty. Please add some entries and try again.");
          }
          else
          {
              journal.DisplayEntries();
          }
          break;


        case "3":
          Console.Write("Enter the file name to save: ");
          string FileName = Console.ReadLine();
          journal.SaveToFile(FileName);
          Console.WriteLine("Journal saved successfully.");
          break;

        case "4":
          Console.Write("Enter the file name to load: ");
          string loadFileName = Console.ReadLine();
          journal.LoadFromFile(loadFileName);
          Console.WriteLine("Journal loaded successfully.");
          break;

        case "5":
          keepRunning = false;
          Console.WriteLine("Thank you for using the Journal program");
          break;

        default:
          Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
          break;
      }
    }
  }
}