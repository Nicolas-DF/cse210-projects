using System;
using System.Diagnostics.Tracing;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} – Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }
        public string ToFileFormat()
    {
        return $"{_date},{_promptText},{_entryText}";
    }
    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split(',');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}