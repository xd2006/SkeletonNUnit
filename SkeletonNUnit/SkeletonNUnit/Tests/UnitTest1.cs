using System;
using NUnit.Framework;
using ReportPortal.Shared;
using SkeletonNUnit.Tests;

namespace SkeletonNUnit
{
    [TestFixture]
    public class UnitTest1:TestBase
    {
        
        [Test]
        public void TestMethod1()
        {

            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Trace, "class1 test1 log message");
            App.Logger.Debug("My debug log message from Log4Net");
            var filePath = TestContext.CurrentContext.TestDirectory + "\\Data\\dog.png";
            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Info, "my dog RP native {rp#file#" + filePath + "}");
            App.Logger.Debug("my dog Log4net {rp#file#" + filePath + "}");
            App.Logger.Debug("Debug Message");
            App.Logger.Error("Test error");
            App.Logger.Warn("Test warning");
            Assert.That(true);
        }
    }
}
