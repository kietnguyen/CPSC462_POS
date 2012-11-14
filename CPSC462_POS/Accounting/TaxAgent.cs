using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class TaxAgent : Person
    {
        private int taxId;
        
        public TaxAgent(int taxId, string first, string last, string dob, string address)
            :base (first, last,dob, address)
        {
            this.taxId = taxId;
        }

        public void collectTax()
        {
            
        }
    }
}
