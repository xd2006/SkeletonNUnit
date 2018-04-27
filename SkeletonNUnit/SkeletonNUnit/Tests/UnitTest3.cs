using System;
using NUnit.Framework;
using ReportPortal.Shared;
using SkeletonNUnit.Tests;

namespace SkeletonNUnit
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class UnitTest3 : TestBase
    {
        [Test]
        public void TestMethod()
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

        [Test]
        public void TestMethodFail3()
        {

            App.Logger.Debug("My debug log message from Log4Net");          
            App.Logger.Debug("Debug Message");
            App.Logger.Error("Test error");
            App.Logger.Warn("Test warning");
            App.Pages.NavigateToBaseUrl();
            Assert.That(false);
        }

        [Test]
        public void TestMethod2()
        {
            App.Logger.Info($"{TestContext.CurrentContext.Test.MethodName} log message");
            App.Pages.NavigateToBaseUrl();
            App.Pages.NavigateToBaseUrl();
            System.Threading.Thread.Sleep(5000);
            App.Logger.Debug("Debug Message");
            App.Logger.Error("Test error");
            App.Logger.Warn("Test warning");
            Assert.That(true);
        }

        [Test]
        public void TestMethod3()
        {
            App.Logger.Info($"{TestContext.CurrentContext.Test.MethodName} log message");
            App.Pages.NavigateToBaseUrl();
            System.Threading.Thread.Sleep(5000);
            App.Logger.Debug("Debug Message");
            App.Logger.Error("Test error");
            App.Logger.Warn("Test warning");
            Assert.That(true);
        }

        [Test]
        public void TestMethod4()
        {
            App.Logger.Info($"{TestContext.CurrentContext.Test.MethodName} log message");
            App.Pages.NavigateToBaseUrl();
            System.Threading.Thread.Sleep(5000);
            App.Logger.Debug("Debug Message");
            App.Logger.Error("Test error");
            App.Logger.Warn("Test warning");
            Assert.That(true);
        }

        [Test]
        public void TestMethod5()
        {
            App.Logger.Info($"{TestContext.CurrentContext.Test.MethodName} log message");
            App.Pages.NavigateToBaseUrl();
            System.Threading.Thread.Sleep(5000);
            App.Logger.Debug("Debug Message");
            App.Logger.Error("Test error");
            App.Logger.Warn("Test warning");
            Assert.That(true);
        }

        [Test]
        public void TestMethod6()
        {
            App.Logger.Info($"{TestContext.CurrentContext.Test.MethodName} log message");
            App.Pages.NavigateToBaseUrl();
            System.Threading.Thread.Sleep(5000);
            App.Logger.Debug("Debug Message");
            App.Logger.Error("Test error");
            App.Logger.Warn("Test warning");
            Assert.That(true);
        }
    }
}
