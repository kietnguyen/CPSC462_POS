using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class Employee : Person
    {
        protected int employeeId;
        protected decimal salary;
        protected Store store;

        public int EmployeeId
        {
            get { return this.employeeId; }
        }

        public Store Store
        {
            get { return this.store; }
            set { this.store = value; }
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
