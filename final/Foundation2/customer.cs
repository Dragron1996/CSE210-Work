using System;

public class Customer
{
    private string _Name {get; set;}
    private Address _address {get; set;}

    public Customer (string Name, Address address)
    {
        _Name = Name;
        _address = address;
    }


    public double GetCost()
    {
        double shippingCost;
        if (_address.GetCountry() == "Ocean")
        {
            shippingCost = 2.75;
        }
        else 
        {
            shippingCost = 27.50;
        }
        return shippingCost;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_Name}\r\n{_address.GetAddress()}");
    }
}