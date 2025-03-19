public class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false; // Initially, the word is not hidden.
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Unhide()
    {
        IsHidden = false;
    }

    public string GetDisplayText()
    {
        return IsHidden ? "_____" : Text;
    }
}
