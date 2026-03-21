using System;
using System.Collections.Generic;

public class Word
{
    private List<string> words = new List<string>();
    private List<string> hiddenWords = new List<string>();
    private Random random = new Random();
    


    public List<string> splitwords(string scripture)
    {
        words = new List<string>(scripture.Split(' '));
        return words;
    }

    public List<string> hide(int count = 1)
    {
        hiddenWords = new List<string>(words);
        while (count > 0)
        {
            int index = random.Next(hiddenWords.Count);

            // the ! makes it so hidden words does not have _
            if (!hiddenWords[index].Contains('_'))
            {
                hiddenWords[index] = new string('_', hiddenWords[index].Length);
                // the -- takes one away after the count variable has been used
                count--;
            }
        }
        return hiddenWords;
    }

    public string Display()
    {
        string adjusted = string.Join(' ', hiddenWords);
        return adjusted;
    }

    public bool AllWordsHidden()
    {
        foreach (string word in hiddenWords)
        {
            if (!word.Contains('_'))
            {
                return false;
            }

        }
            return true;
    }
}