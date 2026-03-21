using System;
// for creativity I adding more scriptures and made it so it chooses a random scripture
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        // for some reason this class was putting up an error, i reloaded visual studio and that seemed to fix it, but keep an eye out here
        Word word = new Word();

        string randomScripture = scripture.SelectRandomScripture();
        (string scriptureReference, string scriptureText) = reference.getReference(randomScripture);
        List<string> words = word.splitwords(scriptureText);

        Console.WriteLine();

        int hiddenWordCount = 0;
        string input = "";
        while (input != "quit")
        {
            List<string> hiddenWords = word.hide(hiddenWordCount);
            string adjusted = word.Display();

            Console.WriteLine($"{scriptureReference} {adjusted}");


            if (word.AllWordsHidden())
            {
                Console.WriteLine("Good Job!");
                break;
            }
            
            hiddenWordCount ++;
            input = Console.ReadLine();
            Console.Clear();


        }

    }
}