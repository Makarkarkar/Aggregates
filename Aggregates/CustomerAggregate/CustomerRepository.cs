using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.CustomerAggregate;

public class CustomerRepository 
{
    private List<Customer> _customers;

    public CustomerRepository()
    {
        _customers = new List<Customer>();
    }

    public void Add(Customer customer)
    {
        _customers.Add(customer);
    }
    
    public void Remove(Customer customer)
    {
        _customers.Remove(customer);
    }

    public void Update(Customer customer)
    {
        var existingCustomer = _customers.FirstOrDefault(c => c.Id == customer.Id);
        if (existingCustomer != null)
        {
            existingCustomer = customer;
        }
    }
}
