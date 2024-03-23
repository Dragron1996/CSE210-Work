using System;

public class Choices
{
     
    private string _menu = @"
Menu Options

Please select one of the following activities to do:
1. Breathing 
2. Reflecting 
3. Listing 
4. Quit

";

    public string _Input;
    private int _Choice = 0;

    
    public int Choice()
    
    {
       
        Console.Clear();
        Console.Write(_menu);

        _Input = Console.ReadLine();
        _Choice = 0;
        
        try
        {
            _Choice = int.Parse(_Input);
        }
        catch (FormatException)
        {
            _Choice = 0;
        }
        return _Choice;
    }



}