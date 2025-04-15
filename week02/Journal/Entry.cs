using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Location { get; set; }
    public string Mood { get; set; }

    public Entry(string prompt, string response, string location, string mood)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        Prompt = prompt;
        Response = response;
        Location = location;
        Mood = mood;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nLocation: {Location}\nMood: {Mood}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}|{Location}|{Mood}";
    }

    public static Entry FromFileString(string fileLine)
    {
        string[] parts = fileLine.Split('|');
        if (parts.Length == 5)
        {
            Entry entry = new Entry(parts[1], parts[2], parts[3], parts[4]);
            entry.Date = parts[0];
            return entry;
        }
        return null;
    }
}
