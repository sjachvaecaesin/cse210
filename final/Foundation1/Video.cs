using System.Transactions;

class Video
{
    private int _length;
    private string _author;
    private string _title;
    private List<Comment> _comments = new List<Comment>();

    public Video(string author, string title, int length, List<Comment> comments)
    {
        _author = author;
        _title = title;
        _length = length;
        _comments = comments;
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author}");
        Console.WriteLine($"This video is {_length} seconds");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"  {comment.toString()}");
        }
    }
}