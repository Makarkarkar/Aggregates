using MyApp.CustomerAggregate;

namespace MyApp.OrderAggregate;

public class OrderFactory
{
    
    public Order Create(Customer customer)
    {
        var order = new Order(customer);
        return order;
    }
}