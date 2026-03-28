public class Video
{
    private string _author;
    private string _title;
    private int _length;
    private List<Comment> _comments = new();


    public void setVideoInfo(params object[] args)
    {
        _author = args[0].ToString();
        _title = args[1].ToString();
        _length = int.Parse(args[2].ToString());
    }

        public void DisplayComment()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommenterName()} - {comment.GetCommenterText()}");
        }
        Console.WriteLine("");
    }

        public void DisplayVideoInfo()
    {
        string meta = $"Author of Video: {GetAuthor()}\nTitle: {GetTitle()}\nVideo length: {GetLength()} seconds";
        Console.WriteLine(meta);
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    } 


}