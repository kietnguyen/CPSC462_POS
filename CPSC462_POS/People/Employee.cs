using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Employee : Person
    {
        private int employeeId;
        private decimal salary;
        public Store store { get; set; }

        public int EmployeeId
        {
            get { return this.employeeId; }
        }

        public Employee(Store aStore, int eId, decimal salary, string first, string last, string dob, string address)
            : base(first, last, dob, address)
        {
            this.employeeId = eId;
            this.store = aStore;
            this.salary = salary;
        }

        public override string showId()
        {
            return employeeId + "\n"
                    + base.showId();
        }

        public virtual void login()
        {

        }

        public virtual void logoff()
        {

        }
    }
}
