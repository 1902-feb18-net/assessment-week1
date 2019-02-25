using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Pal.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            pal test = new pal();
            Assert.IsTrue(test.palindrome("nurses run"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            pal test = new pal();
            Assert.IsTrue(test.palindrome("racecaR"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            pal test = new pal();
            Assert.IsTrue(test.palindrome("1221"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            pal test = new pal();
            Assert.IsTrue(test.palindrome("never odd, or even."));
        }
        [TestMethod]
        public void TestMethod5()
        {
            pal test = new pal();
            Assert.IsTrue(test.palindrome("one two one"));
        }
        [TestMethod]
        public void TestMethod6()
        {
            pal test = new pal();
            Assert.IsTrue(test.palindrome("123abccba123"));
        }
    }
}
