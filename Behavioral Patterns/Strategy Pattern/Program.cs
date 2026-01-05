using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Program
    {
        //Client usage (e.g. controller / service layer....)
        public static void Main()
        {
            CheckoutService service = new CheckoutService(new CreditCardPaymentStrategy());

          PaymentResult result=  service.Checkout(20.2f, "USD");
            if (!result.Success)
            {
                // handle failure
                Console.WriteLine(result.ErrorMessage);
            }

            // switch strategy at runtime
            service = new CheckoutService(new PayPalPaymentStrategy());
            service.Checkout(80, "EUR");
        }
    }
}
