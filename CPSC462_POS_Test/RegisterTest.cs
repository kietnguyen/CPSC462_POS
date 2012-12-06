using CPSC462_POS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CPSC462_POS_Test
{


    [TestClass()]
    public class RegisterTest
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        [TestMethod()]
        public void makePaymentTest()
        {
            int registerId = 0; // TODO: Initialize to an appropriate value
            Register target = new Register(registerId); // TODO: Initialize to an appropriate value
            target.makePayment();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
