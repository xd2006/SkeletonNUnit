using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.WeDriverService;
using log4net;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SkeletonNUnit.Managers;
using SkeletonNUnit.Service;

namespace SkeletonNUnit.Tests
{
    [Parallelizable(ParallelScope.All)]
    public class TestBase
    {
        private ApplicationManager appM;

        /// <summary>
        /// Gets the app. manager
        /// </summary>
        protected ApplicationManager App
        {
            get
            {
                appM = appM ?? new Starter().StartApplicationManager();
                return appM;
            }
            set => appM = value;
        }

        [SetUp]
        public void BeforeTest()
        {
            App.Logger.Info("Test started - " + TestContext.CurrentContext.Test.MethodName);

        }

        [TearDown]
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                App.Logger.Warn("Test failed - " + TestContext.CurrentContext.Test.MethodName);

                if (App.PageManagerExists)
                {
                    var screenPath = new Screenshoter(App.Pages.Driver).TakeScreenshot(
                        TestContext.CurrentContext.Test.MethodName,
                        TestContext.CurrentContext.TestDirectory + "\\Logs");
                    if (!string.IsNullOrEmpty(screenPath))
                    {
                        App.Logger.Info("Screenshot {rp#file# " + screenPath + "}");
                    }
                    else
                    {
                        App.Logger.Warn("Can't make screenshot");
                    }
                }
              }
            else
            {
                App.Logger.Info("Test completed successfully - " + TestContext.CurrentContext.Test.MethodName);
            }
        }


        private void Clean()
        {
            WebDriverFactory.DismissAll();
            App = null;          
        }



    }
}
