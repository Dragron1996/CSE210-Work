using System;

public class Journal
{
    public string _prompt = "";
    public string _write = "";
    public string _date = "5/21/2023";

    public void Display()
    {
        Console.WriteLine($"{_date}- {_prompt}\n{_write}");
    } 

    
}