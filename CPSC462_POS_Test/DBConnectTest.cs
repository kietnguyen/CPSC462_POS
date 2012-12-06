using CPSC462_POS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CPSC462_POS_Test
{


    [TestClass()]
    public class DBConnectTest
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
        public void retrieveItemTest()
        {
            Item actual = new Item(1, new ProductSpecification("Socks", "Hanes", ""), 11.8m);
            Item expected = DBConnect.GetInstance.retrieveItem(1);
            Assert.AreEqual(actual, expected);

            actual = new Item(2, new ProductSpecification("Gum", "Stride", ""), 3.5m);
            expected = DBConnect.GetInstance.retrieveItem(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
