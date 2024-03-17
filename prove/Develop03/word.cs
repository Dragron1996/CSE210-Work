public class Word
{
    public string text { get; }
    public bool hide { get; set; }

    public Word(string verse)
    {
        text = verse;
        hide = false;
    }
}