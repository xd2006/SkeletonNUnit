using System;
using NUnit.Framework;
using ReportPortal.Shared;

namespace SkeletonNUnit
{
    [TestFixture]
    public class UnitTest1
    {
        protected log4net.ILog Log4NetLogger = log4net.LogManager.GetLogger(typeof(UnitTest1));

        [Test]
        public void TestMethod1()
        {

            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Trace, "class1 test1 log message");
            Log4NetLogger.Info("My log message from Log4Net");
//            var filePath = TestContext.CurrentContext.TestDirectory + "\\dog.png";
//            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Info, "my dog RP native {rp#file#" + filePath + "}");
//            Log4NetLogger.Info("my dog Log4net {rp#file#" + filePath + "}");
            Assert.That(true);
        }
    }
}
