using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Core;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SkeletonNUnit.Managers.AuxManagers;

namespace SkeletonNUnit.Managers
{
    public class ApplicationManager
    {

        private string baseUrl;

        private ICapabilities capabilities;

        private string hubUrl;

        /// <summary>
        /// The _pages.
        /// </summary>
        private PageManager pages;

        /// <summary>
        /// The main.
        /// </summary>
//        private MainHelper main;

        /// <summary>
        /// Gets or sets the Log4Net logger.
        /// </summary>
        public ILog Logger { get; set; }

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
            Logger = LogManager.GetLogger("Logger");
        }

        /// <summary>
        /// Gets the pages manager
        /// </summary>
        public PageManager Pages => this.pages ?? (this.pages = new PageManager((DesiredCapabilities) capabilities, this.baseUrl, this.hubUrl));
    }
}
