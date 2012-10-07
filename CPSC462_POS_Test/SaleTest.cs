using CPSC462_POS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CPSC462_POS_Test
{

    [TestClass()]
    public class SaleTest
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
        public void add_itemTest()
        {
            Sale target = new Sale();
            Assert.AreEqual(0, target.getItems().Count);

            target.add_item(new SalesLineItem(1234,1));
            Assert.AreEqual(1, target.getItems().Count);
        }

        [TestMethod()]
        [DeploymentItem("CPSC462_POS.exe")]
        public void findLineItemTest()
        {
            Sale_Accessor target = new Sale_Accessor(); // TODO: Initialize to an appropriate value
            int product_id = 0; // TODO: Initialize to an appropriate value
            SalesLineItem_Accessor expected = null; // TODO: Initialize to an appropriate value
            SalesLineItem_Accessor actual;
            actual = target.findLineItem(product_id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void getItemsTest()
        {
            Sale target = new Sale(); // TODO: Initialize to an appropriate value
            List<SalesLineItem> expected = null; // TODO: Initialize to an appropriate value
            List<SalesLineItem> actual;
            actual = target.getItems();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void getSubTotalTest()
        {
            Sale target = new Sale(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.getSubTotal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void getTaxTest()
        {
            Sale target = new Sale(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.getTax();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void getTotalTest()
        {
            Sale target = new Sale(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = target.getTotal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void remove_itemTest()
        {
            Sale target = new Sale(); // TODO: Initialize to an appropriate value
            SalesLineItem lineItem = null; // TODO: Initialize to an appropriate value
            target.remove_item(lineItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void update_itemTest()
        {
            Sale target = new Sale(); // TODO: Initialize to an appropriate value
            SalesLineItem lineItem = null; // TODO: Initialize to an appropriate value
            target.update_item(lineItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
