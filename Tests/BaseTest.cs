using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;

namespace TricentisTest.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = Drivers.WebDriverFactory.CreateWebDriver();
        }

        [TearDown]
        public void Teardown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        protected void TakeScreenshot(string testName)
        {
            string screenshotsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");
            if (!Directory.Exists(screenshotsDir))
                Directory.CreateDirectory(screenshotsDir);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshotPath = Path.Combine(screenshotsDir, $"{testName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            screenshot.SaveAsFile(screenshotPath);
        }
    }
}
