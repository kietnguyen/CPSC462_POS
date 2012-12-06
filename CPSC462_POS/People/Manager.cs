using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Manager : Employee
    {
        private List<Employee> employees;
<<<<<<< HEAD

        public Manager(Store aStore, int eId, decimal salary, string first, string last, string dob, string address)
            : base(aStore, eId, salary, first, last, dob, address)
        {
            employees = new List<Employee>();
        }
=======
>>>>>>> origin/newbranch

        public Manager(Store aStore, int eId, decimal salary, string first, string last, string dob, string address)
            : base(aStore, eId, salary, first, last, dob, address)
        {
<<<<<<< HEAD
            base.login();
=======
            employees = new List<Employee>();
>>>>>>> origin/newbranch
        }

        public void modifySale()
        {

        }
    }
}
