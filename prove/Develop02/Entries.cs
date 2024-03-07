public class Entries
{
    public string _name;

    public List<Journal> _entries = new List<Journal>();
    public List<Journal> _savefiles = new List<Journal>();
    

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Journal:");

        foreach (Journal entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save()
    {
        foreach (Journal entry in _entries)
        {
            
            _savefiles.Add(entry);
            Console.WriteLine(_savefiles);
            
            
        }
    }
   
    public void Load(SaveFile save)
    {
        _entries.AddRange(save._entries);
        
    }
}