using CPSC462_POS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CPSC462_POS_Test
{

    [TestClass()]
    public class StoreTest
    {

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod()]
        public void addRegisterTest()
        {
            string name = "ABC Market";
            string address = "123 Somewhere St, aCity, aState 00000";
            Store target = new Store(name, address);

            Register aRegister = new Register(1234);
            target.addRegister(aRegister);
            Assert.AreEqual(0, target.getRegisters().IndexOf(aRegister));

            Register anotherRegister = new Register(2345);
            target.addRegister(anotherRegister);
            Assert.AreEqual(1, target.getRegisters().IndexOf(anotherRegister));
        }

        [TestMethod()]
        public void getNumberOfRegistersTest()
        {
            string name = "ABC Market";
            string address = "123 Somewhere St, aCity, aState 00000";
            Store target = new Store(name, address);
            Assert.AreEqual(0, target.getNumberOfRegisters());

            target.addRegister(new Register(1234));
            Assert.AreEqual(1, target.getNumberOfRegisters());

            target.addRegister(new Register(2345));
            Assert.AreEqual(2, target.getNumberOfRegisters());
        }

        [TestMethod()]
        public void removeRegisterTest()
        {
            string name = "ABC Market";
            string address = "123 Somewhere St, aCity, aState 00000";
            Store target = new Store(name, address);

            Register aRegister = new Register(1234);
            target.addRegister(aRegister);
            Assert.AreEqual(0, target.getRegisters().IndexOf(aRegister));

            Register anotherRegister = new Register(2345);
            target.addRegister(anotherRegister);
            Assert.AreEqual(1, target.getRegisters().IndexOf(anotherRegister));

            target.removeRegister(aRegister);
            Assert.AreEqual(-1, target.getRegisters().IndexOf(aRegister));
            Assert.AreEqual(0, target.getRegisters().IndexOf(anotherRegister));

            target.removeRegister(anotherRegister);
            Assert.AreEqual(-1, target.getRegisters().IndexOf(aRegister));
            Assert.AreEqual(-1, target.getRegisters().IndexOf(anotherRegister));
        }

    }
}
