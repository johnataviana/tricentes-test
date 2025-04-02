using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TricentisTest.PageObjects
{
    public class VehicleDataPage
    {
        private IWebDriver driver;

        public VehicleDataPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement FindElement(By by) => driver.FindElement(by);

        private void SelectFromDropdown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

        private void EnterText(IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }

        public void SelectMake(string make) => SelectFromDropdown(FindElement(By.Id("make")), make);

        public void SelectModel(string model) => SelectFromDropdown(FindElement(By.Id("model")), model);

        public void EnterCylinderCapacity(string capacity) => EnterText(FindElement(By.Id("cylindercapacity")), capacity);

        public void EnterEnginePerformance(string performance) => EnterText(FindElement(By.Id("engineperformance")), performance);

        public void EnterDateOfManufacture(string date) => EnterText(FindElement(By.Id("dateofmanufacture")), date);

        public void SelectFuelType(string fuel) => SelectFromDropdown(FindElement(By.Id("fuel")), fuel);

        public void EnterListPrice(string price) => EnterText(FindElement(By.Id("listprice")), price);

        public void EnterLicensePlateNumber(string plate) => EnterText(FindElement(By.Id("licenseplatenumber")), plate);

        public void EnterAnnualMileage(string mileage) => EnterText(FindElement(By.Id("annualmileage")), mileage);

        public void ClickNext() => FindElement(By.Id("nextenterinsurantdata")).Click();
    }
}
