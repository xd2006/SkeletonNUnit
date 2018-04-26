using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SkeletonNUnit.Managers;

namespace SkeletonNUnit.Tests
{
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
            }
            else
            {
                App.Logger.Info("Test completed successfully - " + TestContext.CurrentContext.Test.MethodName);
            }
        }

    }
}
