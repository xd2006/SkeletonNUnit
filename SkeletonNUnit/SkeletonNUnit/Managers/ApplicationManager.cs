using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TestCore.Managers.Interfaces;

namespace SkeletonNUnit.Managers
{
    public class ApplicationManager: IApplicationManager
    {

        private string baseUrl;

        /// <summary>
        /// The capabilities.
        /// </summary>
        private ICapabilities capabilities;

        /// <summary>
        /// The hub url.
        /// </summary>
        private string hubUrl;

        /// <summary>
        /// The _pages.
        /// </summary>
//        private PageManager pages;

        /// <summary>
        /// The main.
        /// </summary>
//        private MainHelper main;

        /// <summary>
        /// Gets or sets the Log4Net logger.
        /// </summary>
        public Logger Logger { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationManager"/> class.
        /// </summary>
        /// <param name="capabilities">
        /// The capabilities.
        /// </param>
        /// <param name="baseUrl">
        /// The base url.
        /// </param>
        /// <param name="hubUrl">
        /// The hub url.
        /// </param>
        public ApplicationManager(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            this.capabilities = capabilities;
            this.baseUrl = baseUrl;
            this.hubUrl = hubUrl;
        }
    }
}
