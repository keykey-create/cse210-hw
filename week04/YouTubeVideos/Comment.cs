public class Comment
{
    private string _commenterName;
    private string _commenterText;

    public Comment(string name, string comment)
    {
        _commenterName = name;
        _commenterText = comment;

    }

    public string GetCommenterName()
    {
        return _commenterName;
    }
    public string GetCommenterText()
    {
        return _commenterText;
    }

}