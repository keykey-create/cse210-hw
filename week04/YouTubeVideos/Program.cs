using System;

class Program
{
    static void Main(string[] args)
    {
List<Video> videos = new();

        void DisplayVideoData()
        {
            int count = 0;
            foreach (Video video in videos)
            {
                count++;
                Console.WriteLine($"Video0{count}");
                video.DisplayVideoInfo();
                Console.WriteLine("\nComments:");
                video.DisplayComment();
            }
        }

        Video video1 = new();
        Video video2 = new();
        Video video3 = new();
        Comment comment = new("GelatinBean", "Wonderful Video!");

        // Video1
        video1.setVideoInfo("Mia Tash", "Life Hacks", 260);
        video1.SetComment(comment);
        comment = new("Jerry24", "Do these actually work?");
        video1.SetComment(comment);
        comment = new("Abigial86", "ooh I am going to have to try these");
        video1.SetComment(comment);
        videos.Add(video1);

        // Video2
        video2.setVideoInfo("philfromfargo", "Explaining insurance in 90 seconds", 90);
        comment = new("Kobias", "Thank you so much!!");
        video2.SetComment(comment);
        comment = new("Joseph Josephson", "Is it bad that i am still confused?");
        video2.SetComment(comment);
        comment = new("Naldo", "This makes so much sense");
        video2.SetComment(comment);
        videos.Add(video2);

        // Video3
        video3.setVideoInfo("Alfie", "Game Design", 70);
        comment = new("Oscar Gonzales", "This game looks so fun");
        video3.SetComment(comment);
        comment = new("GarlicBread", "Is that going to cause issues later?");
        video3.SetComment(comment);
        comment = new("Fogbawa", "Great video as allways Alfie");
        video3.SetComment(comment);
        videos.Add(video3);
        DisplayVideoData();

    }
}