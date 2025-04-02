using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TricentisTest.Steps
{
    [TestFixture]
    public class TricentisTests
    {
        private IWebDriver driver;
        private VehicleDataSteps vehicleDataSteps;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/app.php");

            vehicleDataSteps = new VehicleDataSteps(driver);
        }

        [Test]
        public void Test_FillVehicleData()
        {
            vehicleDataSteps.FillVehicleData();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
