using System;

public class Reference
{
    public(string,string) getReference (string scripture)
    {
        int seperatorIndex = scripture.IndexOf(' ');
        string reference = scripture.Substring(0,seperatorIndex);
        string scriptureText = scripture.Substring(seperatorIndex + 1);
        return (reference, scriptureText);
    }
}