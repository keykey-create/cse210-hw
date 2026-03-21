using System;
using System.Collections.Generic;

public class Scripture
{
    private List<string> scriptures = new List<string>
    {
        "1Nephi-17:51 And now, if the Lord has such great power, and has wrought so many miracles among the children of men, how is it that he cannot instruct me, that I should build a ship?",
        "Proverbs-3:5-6 Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
        "John-3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
    };

    private Random random = new Random();

    public string SelectRandomScripture()
    {
        int index = random.Next(scriptures.Count);
        string scripture = scriptures[index];
        return scripture;
    }
}