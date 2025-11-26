

public class WrittingAssignment : Assignment
{
    private string _title;

    public WrittingAssignment(string title, string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }

    public string GetWrittingInfo()
    {
        return $"{_title} by {_studentName}";
    }
}