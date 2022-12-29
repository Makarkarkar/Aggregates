using System;

namespace MyApp.CustomerAggregate;

public enum PaymentMethodType
{
    Cash,
    Card 
}
public abstract class PaymentMethod
{
    public string Id { get; private set; }
    public Customer Customer { get; private set; }
    public PaymentMethodType Type { get; private set; }

    protected PaymentMethod(PaymentMethodType type)
    {
        Type = type;
        Id = Guid.NewGuid().ToString("N");
    }
    
}