

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problems)
    {
        _problems = problems;
        _textBookSection = textBookSection;
        _studentName = studentName;
        _topic = topic;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}