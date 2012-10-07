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

        public bool addRegister(Register register)
        {
            // need to remove in database
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
                Debug.WriteLine("Register {0} is not existed!", register.getRegisterId());
                return false;
            }

        }

        public bool removeRegister(int registerId)
        {
            foreach (Register aRegister in registers)
            {
                if (aRegister.getRegisterId() == registerId)
                {
                    registers.Remove(aRegister);
                    return true;
                }

            }

            return false;
        }
    }
}
