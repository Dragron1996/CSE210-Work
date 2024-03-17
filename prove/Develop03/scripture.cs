public class Scripture
{
    private string _scripture;
    private List<Word> _words;

    public Scripture(string scripture, string verse)
    {
        _scripture = scripture;
        _words = new List<Word>();
        string[] words = verse.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_scripture);
        foreach (Word word in _words)
        {
            if (word.hide)
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(word.text + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideWord()
    {
        Random random = new Random();
        int place = random.Next(_words.Count);
        _words[place].hide = true;
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.hide);
    }
}