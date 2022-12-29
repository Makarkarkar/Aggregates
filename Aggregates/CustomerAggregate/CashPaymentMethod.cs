namespace MyApp.CustomerAggregate;

public class CashPaymentMethod : PaymentMethod
{
    public string CheckNumber { get; private set; }

     public CashPaymentMethod(string checkNumber) : base(PaymentMethodType.Cash)
     {
         CheckNumber = checkNumber;
     }

     
}