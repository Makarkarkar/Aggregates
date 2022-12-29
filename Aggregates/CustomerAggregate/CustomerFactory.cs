namespace MyApp.CustomerAggregate;

public class CustomerFactory
{
    public Customer Create(string name, PaymentMethod paymentMethod)
    {
        var customer = new Customer(name);
        customer.AddPaymentMethod(paymentMethod);
        return customer;
    }
}