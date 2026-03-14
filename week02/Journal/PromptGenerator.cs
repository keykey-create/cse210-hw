using System;
using System.Collections.Generic;

class PromptGenerator
{
  public static string GetRandomDailyPrompt()
  {
    List<string> dailyprompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What made me smile or laugh today?",
            "What did I learn about myself or the world today?",
            "What was one win I had today?"
        };

    Random random = new Random();
    int index = random.Next(dailyprompts.Count);
    return dailyprompts[index];
  }

    public static string GetRandomWeeklyPrompt()
  {
    List<string> weeklyprompts = new List<string>
        {
            "What is something unexpected that happened to you recently?",
            "What are five small moments that you were grateful for in the past week?",
            "Who has had the greatest influence on your life?",
            "When life gets overwhelming, what do you do to regain composure?",
            "If you had a magic wand to solve any one problem, what would it be and how would your life change?",
            "What are three things you are looking forward to doing this week?",
            "If you could give a gift to anyone, what gift would you give and why?",
            "List your favorite foods, drinks, snacks, desserts, and more. When was the last time you got to enjoy one of them with a friend?"
        };

    Random random = new Random();
    int index = random.Next(weeklyprompts.Count);
    return weeklyprompts[index];
  }

    public static string GetRandomSpiritualPrompt()
  {
    List<string> Spiritualprompts = new List<string>
        {
            "How have you seen the lords hand in your life today?",
            "What is your favorite scripture and why?",
            "What is your favorite hymn and why?",
            "What is a Christlike attribute you are working on?",
            "Describe a time your prayers where answered",
            "What did you learn in your lessons at church this week?",
            "What is one blessing you have seen?"
        };

    Random random = new Random();
    int index = random.Next(Spiritualprompts.Count);
    return Spiritualprompts[index];
  }
}