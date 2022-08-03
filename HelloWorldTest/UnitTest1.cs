using NUnit.Framework;
using System.IO;
using System;
using HelloWorld;

namespace HelloWorldTests
{
    public class Tests
    {
        private const string Expected = "Hello World!";

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 3, 6)]
        public void AddTestInt(int x, int y, int z)
        {
            Assert.AreEqual(Program.Add(x, y), z);
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 3, 6)]
        public void AddTest(double x, double y, double z)
        {
            Assert.AreEqual(Program.Add(x, y), z);
        }

        [TestCase(3, 2, 1)]
        [TestCase(5, 3, 2)]
        [TestCase(6, 3, 3)]
        public void SubstractTest(int x, int y, int z)
        {
            Assert.AreEqual(Program.Substract(x, y), z);
        }

        [TestCase(-3, 3)]
        [TestCase(-5, 5)]
        public void PartialTest(int x, int y)
        {
            Assert.AreEqual(Program.PartiallyTestedCode(x), y);
        }
    }
}