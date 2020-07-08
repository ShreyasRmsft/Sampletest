using NUnit.Framework;
namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            Assert.Pass("Your first passing test");
        }

        [Test, Author("NunitTest"), Category("Nunit")]
        public void TestMethod2()
        {
            Assert.Pass("Your first passing test");
        }

        [Test, Ignore("No reason"), Author("NunitTest")]
        public void TestMethod3()
        {
            Assert.Pass("Your first passing test");
        }

        [Test, Author("NunitTest"), Platform("x86")]
        public void TestMethod4()
        {
            Assert.Pass("Your first passing test");
        }
    }
}
