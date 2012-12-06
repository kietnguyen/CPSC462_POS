using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Manager : Employee
    {
        private List<Employee> employees;

        public Manager(Store aStore, int eId, decimal salary, string first, string last, string dob, string address)
            : base(aStore, eId, salary, first, last, dob, address)
        {
            employees = new List<Employee>();
        }

        public void modifySale()
        {

        }
    }
}
