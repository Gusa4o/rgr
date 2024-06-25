using System;

public class PostalAddress
{
    
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Building { get; set; }
    public string PostalCode { get; set; }

    
    public PostalAddress()
    {
    }

    
    public PostalAddress(string country, string city, string street, string building, string postalCode)
    {
        Country = country;
        City = city;
        Street = street;
        Building = building;
        PostalCode = postalCode;
    }

    
    public void ChangeCountry(string newCountry)
    {
        Country = newCountry;
    }

    public void ChangeCity(string newCity)
    {
        City = newCity;
    }

    public void ChangeStreet(string newStreet)
    {
        Street = newStreet;
    }

    public void ChangeBuilding(string newBuilding)
    {
        Building = newBuilding;
    }

    public void ChangePostalCode(string newPostalCode)
    {
        PostalCode = newPostalCode;
    }

    
    public void DisplayAddress()
    {
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Street: {Street}");
        Console.WriteLine($"Building: {Building}");
        Console.WriteLine($"Postal Code: {PostalCode}");
    }

    
    ~PostalAddress()
    {
        
        Console.WriteLine("PostalAddress object is being destroyed.");
    }
}

class Program
{
    static void Main()
    {
        
        PostalAddress address = new PostalAddress("Ukraine", "Kyiv", "Shevchenko Street", "15A", "01001");

        
        Console.WriteLine("Initial address:");
        address.DisplayAddress();

        
        address.ChangeCountry("USA");
        address.ChangeCity("New York");
        address.ChangeStreet("5th Avenue");
        address.ChangeBuilding("101");
        address.ChangePostalCode("10001");

        
        Console.WriteLine("\nUpdated address:");
        address.DisplayAddress();

        
        address = null;
        GC.Collect(); 
    }
}
