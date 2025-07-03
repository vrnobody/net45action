using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net45action.test
{
    [TestClass]
    public class UtilsTest
    {
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        public void TestMethod1(int a, int b, int expected)
        {
            var result = Utils.Add(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}
