using NUnit.Framework;
using Src;

namespace Tests
{
    public class TestKata
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(-1, Kata.DoSomething());
        }
    }
}