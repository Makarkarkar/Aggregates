using System;
using System.Collections.Generic;
using MyApp.CustomerAggregate;
namespace MyApp.OrderAggregate;

public class Order
{
    public string Id { get; private set; }
    public Customer Customer { get; private set; }
    public DateTime OrderDate { get; private set; }
    public OrderStatus Status { get; private set; }
    public List<Product> Products { get; private set; }
    public Address ShippingAddress { get; private set; }
    public PaymentMethod PaymentMethod { get; private set; }

    
    public Order(Customer customer)
    {
        Customer = customer;
        Id = Guid.NewGuid().ToString("N");
        Status = OrderStatus.Processing;
        OrderDate = DateTime.Now;
        Products = new List<Product>();
        PaymentMethod = customer.PaymentMethod;
    }
    
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void SetShippingAddress(Address address)
    {
        ShippingAddress = address;
    }

    public void SetStatus(OrderStatus status)
    {
        Status = status;
    }
}