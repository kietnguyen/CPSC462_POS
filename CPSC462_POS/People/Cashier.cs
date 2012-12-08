using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class Cashier : Employee
    {
        public Cashier(Store aStore,
            int eId, decimal salary, string first, string last, string dob, string address)
            : base(aStore, eId, salary, first, last, dob, address)
        {
        }


    }
}
