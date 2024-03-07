public class SaveFile
{
    public string _name;
    

    public List<Journal> _entries = new List<Journal>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Journal:");

        foreach (Journal entry in _entries)
        {
            entry.Display();
        }
    }
    public void Save(Entries option2)
{
    _entries.AddRange(option2._entries);
    Console.WriteLine("Entries added to savefile.");
    Console.WriteLine(_entries);
}
}