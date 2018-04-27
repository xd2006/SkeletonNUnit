using System;
using System.Collections.Specialized;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SkeletonNUnit.Managers;

namespace SkeletonNUnit.Service
{
    public class Starter
    {
        /// <summary>
        /// The application settings.
        /// </summary>
        private readonly NameValueCollection _appSettings = System.Configuration.ConfigurationManager.AppSettings;

        /// <summary>
        /// The start application manager.
        /// </summary>
        /// <returns>
        /// The <see cref="ApplicationManager"/>.
        /// </returns>
        public ApplicationManager StartApplicationManager()
        {
            // Initially try to get values from env variables and then form app.config
            var browser = Environment.GetEnvironmentVariable("BROWSER") ?? _appSettings["Browser"] ?? "chrome";
            var baseUrl = Environment.GetEnvironmentVariable("URL") ?? _appSettings["Url"];
            var hubUrl = Environment.GetEnvironmentVariable("HUBURL") ?? _appSettings["HubUrl"];

            var capabilities = DefineCapabilities(browser);

            var app = new ApplicationManager(capabilities, baseUrl, hubUrl);
            return app;
        }

        /// <summary>
        /// The define capabilities.
        /// </summary>
        /// <param name="browser">
        /// The browser.
        /// </param>
        /// <returns>
        /// The <see cref="ICapabilities"/>.
        /// </returns>
        private static ICapabilities DefineCapabilities(string browser)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, browser);
            return capabilities;
        }
    }
}
    

