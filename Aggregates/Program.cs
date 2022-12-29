using System;
using MyApp.CustomerAggregate;
using MyApp.OrderAggregate;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerRepository = new CustomerRepository();
            
            var customerFactory = new CustomerFactory();

            var cashCustomer = customerFactory.Create("Makar Ivanenko", new CashPaymentMethod("123141254"));
                customerRepository.Add(cashCustomer);

            var cardCustomer1 = customerFactory.Create("Andrey Pochitaev",
                    new CardPaymentMethod("4433 1233 1232 1235", "Andrey Pochitaev", "12/2024", CardType.Mir));
                customerRepository.Add(cardCustomer1);
                
            var cardCustomer2 = customerFactory.Create("Alisa Zubatova",
                    new CardPaymentMethod("4421 6833 1612 9712", "Alisa Zubatova", "11/2025", CardType.Mastercard));
                customerRepository.Add(cardCustomer2);
                
            var cardCustomer3 = customerFactory.Create("Pavel Arhipov",
                    new CardPaymentMethod("4123 1123 7943 2374", "Pavel Arhipov", "14/2024", CardType.Visa));
                
            customerRepository.Add(cardCustomer3);

            var orderRepository = new OrderRepository();
                
            var orderFactory = new OrderFactory();
            var order = orderFactory.Create(cardCustomer2);
            order.AddProduct(new Product("Grill", 6200));
            order.AddProduct(new Product("Haliky sweatshirt", 4200));
            order.AddProduct(new Product("Oven", 19000));
            order.SetShippingAddress(new Address("123 Main St", "New York", "USA", "10001"));
            orderRepository.Add(order);
            
            order.SetStatus(OrderStatus.Created);
            Console.WriteLine($"Заказ {order.Id} для {order.Customer.Name} создан");
            order.SetStatus(OrderStatus.Paid);
            Console.WriteLine($"Заказ {order.Id} для {order.Customer.Name} оплачен");
            order.SetStatus(OrderStatus.Processing);
            Console.WriteLine($"Заказ {order.Id} для {order.Customer.Name} в процессе доставки");
            order.SetStatus(OrderStatus.Delivered);
            Console.WriteLine($"Заказ {order.Id} для {order.Customer.Name} доставлен:");
            foreach (var product in order.Products)
                    {
                        Console.WriteLine($"{product.Name}, {product.Price}р");
                    }
        }
    }
}