﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Cashier : Employee
    {
        private Register register;

        public Register Register
        {
            get { return register; }
        }

        public Cashier(Register register, Store aStore,
            int eId, decimal salary, string first, string last, string dob, string address)
            : base(aStore, eId, salary, first, last, dob, address)
        {
            this.register = register;
        }


    }
}
