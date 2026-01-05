using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Strategy interface
    public interface IPaymentStrategy
    {
       public PaymentResult Pay(PaymentRequest request);
    }
}
