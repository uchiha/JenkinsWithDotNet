using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestJenkinsWithDotNet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello JenkinsCI", JenkinsWithDotNet.Program.CreateMessage());
        }
    }
}
