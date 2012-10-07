using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    interface IPaymentMethod
    {
        void process(decimal amount);
    }
}
