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

        public Employee()
        {
        }

        public Employee(Store aStore, int eId, decimal salary)
        {
            this.employeeId = eId;
            this.store = aStore;
            this.salary = salary;
        }

        public int getEmployeeId()
        {
            return this.employeeId;
        }

        public override string showId()
        {
            return base.showId();
        }

        public virtual void login()
        {

        }

        public virtual void logoff()
        {

        }
    }
}
