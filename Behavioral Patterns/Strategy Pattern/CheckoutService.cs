using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //business logic stays unchanged
    public class CheckoutService
    {
        private IPaymentStrategy _strategy;
        public CheckoutService(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public PaymentResult Checkout(float amount, string currency)
        {
            return _strategy.Pay(new PaymentRequest { Amount = amount, Currency=currency });
        }

    }
}
