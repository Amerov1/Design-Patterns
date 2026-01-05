using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //First concrete strategy
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public PaymentResult Pay(PaymentRequest request)
        {
            if (request.Currency != "EUR")
            {
                return new PaymentResult
                {
                    Success = false,
                    ErrorMessage = "only Support EUR"
                };
            }
            return new PaymentResult
            {
                Success = true,
            };
        }
    }
}
