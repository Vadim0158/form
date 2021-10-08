using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(7, Logic.FindMax(437));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, Logic.FindMax(100));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(9, Logic.FindMax(999));
        }
    }
}
