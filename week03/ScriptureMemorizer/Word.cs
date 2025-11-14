
using System.Diagnostics;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        
    }
    public void Show()
    {
        
    }
    public bool IsHidden()
    {
        return true;
    }
    public string GetDisplayText()
    {
        string text = _text;
        return text;
    }
}