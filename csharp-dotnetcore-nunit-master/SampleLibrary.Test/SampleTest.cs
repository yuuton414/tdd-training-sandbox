using NUnit.Framework;

namespace SampleLibrary.Test
{
    public class SampleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSay()
        {
            var sample = new Sample();
            Assert.AreEqual("Hello TDD Boot Camp!", sample.Say());
        }
    }
}