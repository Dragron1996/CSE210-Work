using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Address address1 = new Address ("1st Big Rock.", "Bikini Bottom", "Pacific", "Ocaen (I think that's how you spell it)");
        Customer customer1 = new Customer("Patrick Star", address1);

        double order1ShippingCost = customer1.GetCost();

        Product order1Product1 = new Product("Small Rock", "6456", 0.50, 10);
        Product order1Product2 = new Product("Big Boulder", "0835", 0.25, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.GetSubtotal();
        double order1Total = order1.GetTotal();

        order1.DisplayLabel(); 
        Console.WriteLine();
        order1.DisplayShippingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);

        Address address2 = new Address ("3rd Pineapple", "Bikini Bottom", "Pacific", "Ocean");
        Customer customer2 = new Customer("SpongeBob", address2);

        double order2ShippingCost = customer2.GetCost();

        Product order2Product1 = new Product("Crabby Patty", "5342", 1.50, 10);
        Product order2Product2 = new Product("Spatulla", "6558", 6.00, 1);
        Product order2Product3 = new Product("Gary Food", "7988", 1.25, 12);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.GetSubtotal();
        double order2Total = order2.GetTotal();

        order2.DisplayLabel(); 
        Console.WriteLine();
        order2.DisplayShippingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        
    }   
    }
