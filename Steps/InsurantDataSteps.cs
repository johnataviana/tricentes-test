using NUnit.Framework;
using OpenQA.Selenium;
using TricentisTest.PageObjects;

namespace TricentisTest.Steps
{
    public class InsurantDataSteps
    {
        private InsurantDataPage insurantDataPage;

        public InsurantDataSteps(IWebDriver driver)
        {
            insurantDataPage = new InsurantDataPage(driver);
        }


        public void FillInsurantData()
        {
            insurantDataPage.EnterFirstName("John");
            insurantDataPage.EnterLastName("Doe");
            insurantDataPage.EnterDateOfBirth("01/01/1985");
            insurantDataPage.SelectGender("Male");
            insurantDataPage.EnterStreetAddress("123 Main Street");
            insurantDataPage.SelectCountry("United States");
            insurantDataPage.EnterZipCode("12345");
            insurantDataPage.EnterCity("New York");
            insurantDataPage.SelectOccupation("Employee");
            insurantDataPage.SelectHobbies(new List<string> { "Bungee Jumping", "Skydiving" });
            insurantDataPage.EnterWebsite("http://johndoe.com");
            insurantDataPage.UploadPicture("C:\\Users\\JohnDoe\\Pictures\\profile.jpg");
            insurantDataPage.ClickNext();
        }
    }
}
