using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace CPSC462_POS
{
    public class Store
    {
        private string name;
        private string address;
        private List<Register> registers;

        public Store(string name, string address)
        {
            this.name = name;
            this.address = address;
            this.registers = new List<Register>();
        }

        public int getNumberOfRegisters()
        {
            return registers.Count();
        }

        public List<Register> getRegisters()
        {
            return this.registers;
        }

        public bool addRegister(Register register)
        {
            // mask register "using"
            registers.Add(register);

            return true;
        }

        public bool removeRegister(Register register)
        {
            int numberOfRegister = getNumberOfRegisters();
            registers.Remove(register);

            if (numberOfRegister == registers.Count - 1)
            {
                return true;
            }
            else
            {
                Debug.WriteLine("Register {0} is not existed!", register.getId());
                return false;
            }

        }

        public bool removeRegister(int registerId)
        {
            foreach (Register aRegister in registers)
            {
                if (aRegister.getId() == registerId)
                {
                    // mask register "not_using"
                    registers.Remove(aRegister);
                    return true;
                }

            }

            return false;
        }
    }
}
