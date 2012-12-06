using CPSC462_POS.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace CPSC462_POS_Test
{


    [TestClass()]
    public class StringParserTest
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
        [DeploymentItem("CPSC462_POS.exe")]
        public void StringParserConstructorTest()
        {
            Type sp = typeof(TextBoxParser);
            ConstructorInfo[] cInfos = sp.GetConstructors();
            bool hasPublicContructor = false;

            foreach (ConstructorInfo ci in cInfos)
            {
                if (ci.IsPublic)
                {
                    hasPublicContructor = true;
                    break;
                }
            }

            Assert.IsFalse(hasPublicContructor);
        }

        [TestMethod()]
        public void GetInstanceTest()
        {
            TextBoxParser parser1 = TextBoxParser.GetInstance;
            TextBoxParser parser2 = TextBoxParser.GetInstance;
            Assert.AreSame(parser1, parser2);
        }
    }
}
