using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CPSC462_POS
{
    [TestFixture]
    class TestStore
    {
        [Test]
        public void testAll()
        {
            Store aStore = new Store("ABC Market", "123 Somewhere St, aCity, aState aZipcode");
            Assert.AreEqual(0, aStore.getNumberOfRegisters());

            Register aRegister = new Register(1234);
            aStore.addRegister(aRegister);
            Assert.AreEqual(1, aStore.getNumberOfRegisters());

            Register anotherRegister = new Register(2345);
            aStore.addRegister(anotherRegister);
            Assert.AreEqual(2, aStore.getNumberOfRegisters());

            aStore.removeRegister(1234);
            Assert.AreEqual(1, aStore.getNumberOfRegisters());
        }
    }
}
