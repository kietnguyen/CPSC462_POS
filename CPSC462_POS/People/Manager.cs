using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Manager : Employee
    {
        private List<Register> registers;

        public override void login()
        {
            this.registers = base.store.getRegisters();
            base.login();
        }

        public void modifySale()
        {

        }
    }
}
