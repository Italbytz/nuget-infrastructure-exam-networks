using System.Net;
using Knom.Helpers.Net;
using NUnit.Framework;

namespace Italbytz.Infrastructure.Exam.Networks.Tests
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
            var IPAddr = IPAddress.Parse("1.40.15.233");
            var SubMask = SubnetMask.CreateByNetBitLength(22);
            Assert.AreEqual("1.40.12.0", IPAddr.GetNetworkAddress(SubMask).ToString());
            Assert.AreEqual("0.0.3.233", IPAddr.GetHostAddress(SubMask).ToString());
        }
    }
}
