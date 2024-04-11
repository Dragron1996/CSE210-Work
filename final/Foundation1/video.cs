public class Video
{
    private string _youtuber;
    private string _video;
    private int _Length;
    private List<Comments> _comments = new();

    
    public void SetMeta(params object[] args)
    {
        _youtuber = args[0].ToString();
        _video = args[1].ToString();
        _Length = int.Parse(args[2].ToString());
    }

    public string Getyoutuber()
    {
        return _youtuber;
    }

    public string GetVideo()
    {
        return _video;
    }

    public int GetLength()
    {
        return _Length;
    }

    public void SetComment(Comments comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComment()
    {
        foreach (Comments comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()} - {comment.GetComment()}");
        }
        Console.WriteLine("");
    }

    public void DisplayData()
    {
        string meta = $"Youtuber: {Getyoutuber()}\nVideo: {GetVideo()}\nlength: {GetLength()}min(s)";
        Console.WriteLine(meta);
    }
}