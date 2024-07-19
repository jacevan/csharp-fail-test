using NUnit.Framework;
using NUnit.Framework.Legacy;
using SimpleApp;

namespace SimpleApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Fail("FAILURE!!!!!");
        }

        // [Test]
        // public void TestAddition()
        // {
        //     var program = new Program();
        //     int result = program.Add(2, 3);
        //     ClassicAssert.AreEqual(5, result); // Correct method name
        // }
    }
}