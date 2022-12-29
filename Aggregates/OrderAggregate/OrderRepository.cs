using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.OrderAggregate;

public class OrderRepository 
{
    private List<Order> _orders;

    public OrderRepository()
    {
        _orders = new List<Order>();
    }

    public void Add(Order order)
    {
        _orders.Add(order);
    }

    public void Remove(Order order)
    {
        _orders.Remove(order);
    }

    public void Update(Order order)
    {
        var existingOrder = _orders.FirstOrDefault(o => o.Id == order.Id);
        if (existingOrder != null)
        {
            existingOrder = order;
        }
    }
}