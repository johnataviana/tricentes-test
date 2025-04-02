using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TricentisTest.Drivers
{
    public class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/app.php");
            return driver;
        }
    }
}
