public class Comments
{
    private string _Name;
    private string _Comment;

    public Comments(string name, string comment)
    {
        _Name = name;
        _Comment = comment;
    }
    
    public string GetName()
    {
        return _Name;
    }
    public string GetComment()
    {
        return _Comment;
    }
}