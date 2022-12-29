using System;
using System.Collections.Generic;

namespace MyApp.CustomerAggregate;


public class Customer
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public PaymentMethod PaymentMethod { get; private set; }
    
    
    private Customer()
    {
        Id = Guid.NewGuid().ToString("N");
    }
    
    public Customer(string name): this()
    {
        Name = name;
    }

    public void AddPaymentMethod(PaymentMethod paymentMethod)
    {
        PaymentMethod = paymentMethod;
    }
    
    
}