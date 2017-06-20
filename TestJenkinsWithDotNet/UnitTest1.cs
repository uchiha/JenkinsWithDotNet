using System;
using NUnit.Framework;

namespace TestJenkinsWithDotNet
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello JenkinsC", JenkinsWithDotNet.Program.CreateMessage());
        }
    }
}
