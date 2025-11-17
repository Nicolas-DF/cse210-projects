using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        if (string.IsNullOrEmpty(text))
        {
            return;
        }

        // Spliting into simple spaces. Each piece turns into a token.
        // Preserves words with comma (ex: "knowledge,")
        var tokens = text.Split(' ');

        foreach (var token in tokens)
        {
            _words.Add(new Word(token));
        }

    }

    public void HideRandomNumbers(int numberToHide)
    {
        int count = 3;
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        Random random = new Random();
        List<Word> mixed = visibleWords.OrderBy(w => random.Next()).ToList();

        for (int i = 0; i < count && i < mixed.Count; i++)
        {
            mixed[i].Hide();
        }
    }
    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}