using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class Register
    {
        private int registerId;
        private SalesLineItem sale;
        private Store store;
        private Cashier cashier;

        public Register(int registerId)
        {
            this.registerId = registerId;
        }

        public int getId()
        {
            return registerId;
        }

    }
}
