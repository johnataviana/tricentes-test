using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TricentisTest.Steps;

namespace TricentisTest.Tests
{
    [TestFixture]
    public class TricentisTests
    {
        private IWebDriver driver;
        private VehicleDataSteps vehicleDataSteps;
        private InsurantDataSteps insurantDataSteps;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/app.php");

            vehicleDataSteps = new VehicleDataSteps(driver);
            insurantDataSteps = new InsurantDataSteps(driver);
        }

        [Test]
        public void Test_FillVehicleAndInsurantData()
        {
            vehicleDataSteps.FillVehicleData();
            insurantDataSteps.FillInsurantData();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
