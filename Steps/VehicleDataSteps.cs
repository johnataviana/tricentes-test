using NUnit.Framework;
using OpenQA.Selenium;
using TricentisTest.PageObjects;

namespace TricentisTest.Steps
{
    public class VehicleDataSteps
    {
        private VehicleDataPage vehicleDataPage;

        public VehicleDataSteps(IWebDriver driver)
        {
            vehicleDataPage = new VehicleDataPage(driver);
        }

        public void FillVehicleData()
        {
            vehicleDataPage.SelectMake("BMW");
            vehicleDataPage.SelectModel("Scooter");
            vehicleDataPage.EnterCylinderCapacity("130");
            vehicleDataPage.EnterEnginePerformance("120");
            vehicleDataPage.EnterDateOfManufacture("01/01/2022");
            vehicleDataPage.SelectFuelType("Diesel");
            vehicleDataPage.EnterListPrice("25000");
            vehicleDataPage.EnterLicensePlateNumber("ABC1234");
            vehicleDataPage.EnterAnnualMileage("15000");
            vehicleDataPage.ClickNext();
        }
    }
}
