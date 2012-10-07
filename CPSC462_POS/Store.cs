using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CPSC462_POS
{
    public class Store
    {
        private string name;
        private string address;
        private ArrayList registers;

        public Store(string name, string address)
        {
            this.name = name;
            this.address = address;
            this.registers = new ArrayList();
        }

        public bool addRegister(Register register)
        {
            // need to remove in database
            registers.Add(register);

            return true;
        }

        public bool removeRegister(Register register)
        {
            registers.Remove(register);

            return true;
        }

        public bool removeRegister(int registerId)
        {
            registers.RemoveAt(registerId);

            return true;
        }
    }
}
