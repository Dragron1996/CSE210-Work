using System.Text;

class SaveLoadCSV
{
    public static void SaveFile(List<String> _Save, string _file)
    {
        File.WriteAllLines(_file, _Save);
    }

    public static List<String> LoadCSV(string _file)
    {
        List<string> fromCSV = new List<string>();
        StreamReader streamReader = new StreamReader(_file);
        
        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            fromCSV.Add(line.ToString());
        }   
        streamReader.Close();

        return fromCSV;
    }   
}