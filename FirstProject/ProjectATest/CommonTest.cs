using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectA;

namespace ProjectATest
{
    [TestClass]
    public class CommonTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            Common comon = new Common();
            Assert.AreEqual("Name", comon.GetName());
        }
    }
}
