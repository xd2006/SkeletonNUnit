using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core.WeDriverService
{
    public class Screenshoter
    {
        private IWebDriver _driver;
        public Screenshoter(IWebDriver driver)
        {
            _driver = driver;
        }

        public string TakeScreenshot(IWebDriver driver, string scenarioTitle, string logFolder)
        {
            try
            {
                string fileNameBase = $"{scenarioTitle}_{DateTime.Now:yyyy-MM-dd_HHmmss}";
                string folderNameBase = $"{scenarioTitle}_{DateTime.Now:yyyy-MM-dd_HHmm}";

                string artifactDirectory = Path.GetFullPath(Path.Combine(logFolder, folderNameBase));

                if (!Directory.Exists(artifactDirectory))
                {
                    Directory.CreateDirectory(artifactDirectory);
                }

                ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;

                if (takesScreenshot != null)
                {
                    var screenshot = takesScreenshot.GetScreenshot();

                    string screenshotFilePath = Path.Combine(artifactDirectory, fileNameBase + "_screenshot.png");

                    screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);

                    return screenshotFilePath;
                }

                return string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
