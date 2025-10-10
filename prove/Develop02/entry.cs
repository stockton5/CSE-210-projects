public class Entry
{
    public string Date;
    public string Text; 

    public Entry(string date, string text)
    {
        Date = date;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Date}: {Text}";
    }

    public string ToFileString()
    {
        return $"{Date}|{Text}";
    }

    public static Entry FromFileString(string data)
{
    string[] parts = data.Split('|', 2);

    if (parts.Length == 2)
    {
        return new Entry(parts[0], parts[1]);
    }
    else
    {
        return new Entry("Unknown Date", data);
    }
}
}