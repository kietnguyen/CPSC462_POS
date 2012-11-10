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

        //[TestMethod()]
        //public void add_itemTest()
        //{
        //    Sale target = new Sale();
        //    Assert.AreEqual(0, target.getItems().Count);

        //    target.add_item(new SalesLineItem(1234, 1));
        //    Assert.AreEqual(1, target.getItems().Count);

        //    target.add_item(new SalesLineItem(1234, 2));
        //    Assert.AreEqual(1, target.getItems().Count);
        //    Assert.AreEqual(3, target.getItems().ToArray()[0].getQty());

        //    target.add_item(new SalesLineItem(2345, 3));
        //    Assert.AreEqual(2, target.getItems().Count);

        //    target.add_item(new SalesLineItem(3456, 0));
        //    Assert.AreEqual(2, target.getItems().Count);
        //}

        //[TestMethod()]
        //public void remove_itemTest()
        //{
        //    Sale target = new Sale();
        //    target.add_item(new SalesLineItem(1234, 1));
        //    target.add_item(new SalesLineItem(2345, 3));
        //    target.add_item(new SalesLineItem(3456, 2));
        //    Assert.AreEqual(3, target.getItems().Count);

        //    target.remove_item(new SalesLineItem(1234, 1));
        //    Assert.AreEqual(2, target.getItems().Count);
        //    Assert.AreEqual(2345, target.getItems().ToArray()[0].getItem().getID());
        //    Assert.AreEqual(3456, target.getItems().ToArray()[1].getItem().getID());

        //    target.remove_item(new SalesLineItem(2345, 1));
        //    Assert.AreEqual(2, target.getItems().Count);
        //    Assert.AreEqual(2, target.getItems().ToArray()[0].getQty());

        //    target.remove_item(new SalesLineItem(2345, 0));
        //    Assert.AreEqual(2, target.getItems().Count);
        //    Assert.AreEqual(2, target.getItems().ToArray()[0].getQty());

        //    target.remove_item(new SalesLineItem(2345, 2));
        //    Assert.AreEqual(1, target.getItems().Count);
        //    Assert.AreEqual(3456, target.getItems().ToArray()[0].getItem().getID());
        //}

        //[TestMethod()]
        //[DeploymentItem("CPSC462_POS.exe")]
        //public void findLineItemTest()
        //{
        //    Sale_Accessor target = new Sale_Accessor(); // TODO: Initialize to an appropriate value
        //    int product_id = 0; // TODO: Initialize to an appropriate value
        //    SalesLineItem_Accessor expected = null; // TODO: Initialize to an appropriate value
        //    SalesLineItem_Accessor actual;
        //    actual = target.findLineItem(product_id);
        //    Assert.AreEqual(expected, actual);
        //    Assert.Inconclusive("Verify the correctness of this test method.");
        //}

        //[TestMethod()]
        //public void getItemsTest()
        //{
        //    Sale target = new Sale(); // TODO: Initialize to an appropriate value
        //    List<SalesLineItem> expected = null; // TODO: Initialize to an appropriate value
        //    List<SalesLineItem> actual;
        //    actual = target.getItems();
        //    Assert.AreEqual(expected, actual);
        //    Assert.Inconclusive("Verify the correctness of this test method.");
        //}

        [TestMethod()]
        public void subTotalTest()
        {
            Sale target = new Sale();
            target.add_item(new SalesLineItem(1, 1));
            Assert.AreEqual("$11.80", target.getSubTotal().ToString("C"));

            target.add_item(new SalesLineItem(2, 3));
            target.add_item(new SalesLineItem(3, 2));
            Assert.AreEqual("$26.28", target.getSubTotal().ToString("C"));
        }

        [TestMethod()]
        public void taxTest()
        {
            Sale target = new Sale();
            target.add_item(new SalesLineItem(1, 1));
            Assert.AreEqual("$0.94", target.getTax().ToString("C"));

            target.add_item(new SalesLineItem(2, 3));
            target.add_item(new SalesLineItem(3, 2));
            Assert.AreEqual("$2.10", target.getTax().ToString("C"));
        }

        [TestMethod()]
        public void totalTest()
        {
            Sale target = new Sale();
            target.add_item(new SalesLineItem(1, 1));
            Assert.AreEqual("$12.74", target.getTotal().ToString("C"));

            target.add_item(new SalesLineItem(2, 3));
            target.add_item(new SalesLineItem(3, 2));
            Assert.AreEqual("$28.38", target.getTotal().ToString("C"));
        }

        //[TestMethod()]
        //public void update_itemTest()
        //{
        //    Sale target = new Sale(); // TODO: Initialize to an appropriate value
        //    SalesLineItem lineItem = null; // TODO: Initialize to an appropriate value
        //    target.update_item(lineItem);
        //    Assert.Inconclusive("A method that does not return a value cannot be verified.");
        //}
    }
}
