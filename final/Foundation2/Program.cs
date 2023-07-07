using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Apple", "1234", 1.99, 3);
        Product p2 = new Product("Rice", "7890", 2.99, 4);

        Address ad1 = new Address("123 Hollow Lane", "Sacramento", "CA", "USA");
        Custormer c1 = new Custormer("Mandy Rose Jones", ad1);

        Address ad2 = new Address("9000 85th Street", "London", "Uk", "UK");
        Custormer c2 = new Custormer("Matt Smith", ad2);

        Console.WriteLine();
        
        Order or1 = new Order(c1);
        or1.AddProduct(p1);
        or1.AddProduct(p2);

        Order or2 = new Order(c2);
        or2.AddProduct(p2);

        Console.WriteLine(or1.GetPackingLabel());
        Console.WriteLine(or1.GetShippingLabel());
        Console.WriteLine("Your Total Price: $" + or1.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine(or2.GetPackingLabel());
        Console.WriteLine(or2.GetShippingLabel());
        Console.WriteLine("Your Total Price: $" + or2.GetTotalPrice());

        Console.WriteLine();


    }
}