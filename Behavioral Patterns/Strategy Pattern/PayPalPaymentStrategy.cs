using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod { 
    public class PayPalPaymentStrategy: IPaymentStrategy
    {
        //Second concrete strategy
        public PaymentResult Pay(PaymentRequest request)
        {
          if(request.Amount<0)
            {
                return new PaymentResult
                {
                    Success = false,
                    ErrorMessage= "Invalid amount"
                };
            }
            return new PaymentResult
            {
                Success = true,
            };
        }
    }

}