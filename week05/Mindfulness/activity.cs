using System;
using System.Collections.Generic;
using System.Diagnostics;
 class Activity
    {
        public static Dictionary<string, int> ActivityLog { get; } = new Dictionary<string, int>();

        public string Menu()
        {
            Console.Write("Menu Options:\n  1. Breathing Activity\n  2. Reflection Activity\n  3. Listing Activity\n  4. Activity Log\n  5. Quit\nSelect a choice from the menu: ");
            string menuChoice = Console.ReadLine();

            if (menuChoice != "1" && menuChoice != "2" && menuChoice != "3" && menuChoice != "4")
            {
                string process = Process.GetCurrentProcess().ProcessName;
                Process.Start("cmd.exe", "/c taskkill /F /IM " + process + ".exe /T");
            }
            return menuChoice;
        }

        // Generates and returns the introduction message for an activity
        public string Start(string name, string description)
        {
            string introMessage = $"Welcome to the {name} activity! \n\n{description}.";
            return introMessage;
        }

        public int GetDuration()
        {
            Console.WriteLine("How long, in seconds, would you like your session to be? ");
            int duration = Convert.ToInt32(Console.ReadLine());
            return duration;
        }


        public string End(string name, string accomplishment, string actualDuration)
        {
            string sendOffMessage = $"Good Job on completing the {name} activity! You accomplished {accomplishment}. It took you {actualDuration} seconds.";
            return sendOffMessage;
        }


        public void DisplayActivityLog()
        {
            Console.WriteLine("Activity Log:");

            foreach (KeyValuePair<string, int> entry in ActivityLog)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} times");
            }
        }
    }