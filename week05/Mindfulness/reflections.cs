using System;
using System.Collections.Generic;
using System.Diagnostics;

 class Reflection : Activity
    {
        private string _activityName = "Reflection";
        private List<string> _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public void PerformActivity()
        {
            string introMessage = Start(_activityName, "Reflect on times in your life when you have shown strength and resilience.");
            Console.WriteLine(introMessage);

            int duration = GetDuration();

            Console.WriteLine("Prepare to begin...");
            System.Threading.Thread.Sleep(2000); 

            Console.WriteLine("Starting activity...");

            int countdownDuration = duration;
            Random random = new Random();

            while (countdownDuration > 0)
            {
                string prompt = _prompts[random.Next(_prompts.Count)];
                Console.WriteLine(prompt);

                foreach (string question in _questions)
                {
                    Console.WriteLine(question);

                    System.Threading.Thread.Sleep(3000); 
                    Console.Write(". "); 
                    System.Threading.Thread.Sleep(500); 
                }

                countdownDuration -= _questions.Count;
            }

            System.Threading.Thread.Sleep(5000); 

            string sendOffMessage = End(_activityName, "reflecting on your experiences", duration.ToString());
            Console.WriteLine(sendOffMessage);

            if (ActivityLog.ContainsKey(_activityName))
            {
                ActivityLog[_activityName]++;
            }
            else
            {
                ActivityLog[_activityName] = 1;
            }
        }
    }