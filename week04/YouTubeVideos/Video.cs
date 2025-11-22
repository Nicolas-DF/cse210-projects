

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {
        return _comments.Count();
    }
    public void DisplayInfo()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Number of comments: {CountComments()}");
            
            foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._name}: {comment._text}");
        }
        Console.WriteLine();
        }
}