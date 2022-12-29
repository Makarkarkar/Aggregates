using System;

namespace MyApp.OrderAggregate;

public class Address
{
    public string Id { get; private set; }
    public string Street { get; private set; }
    public string City { get; private set; }
    public string Country { get; private set; }
    public string ZipCode { get; private set; }
    
    public Address(string street, string city, string country, string zipCode)
    {
        Street = street;
        City = city;
        Country = country;
        ZipCode = zipCode;
        Id = Guid.NewGuid().ToString("N");
    }
}