using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{

    class Customer : Person
    {
        private int customerId;

        public int CustomerId
        {
            get { return customerId; }
        }

        public Customer(int id, string first, string last, string dob, string address)
            : base(first, last, dob, address)
        {
            customerId = id;
        }

        public override string showId()
        {
            return customerId + "\n"
                    + base.showId();
        }
    }
}
