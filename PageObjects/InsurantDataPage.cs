using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TricentisTest.PageObjects
{
    public class InsurantDataPage
    {
        private IWebDriver driver;

        public InsurantDataPage(IWebDriver driver)
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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));


            element.Clear();
            element.SendKeys(value);
        }

        public void EnterFirstName(string firstName) => EnterText(FindElement(By.Id("firstname")), firstName);

        public void EnterLastName(string lastName) => EnterText(FindElement(By.Id("lastname")), lastName);

        public void EnterDateOfBirth(string dob) => EnterText(FindElement(By.Id("birthdate")), dob);

        public void SelectGender(string gender)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            if (gender.ToLower() == "male")
            {
                IWebElement maleRadio = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id='gendermale']/following-sibling::span")));
                maleRadio.Click();
            }
            else
            {
                IWebElement femaleRadio = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id='genderfemale']/following-sibling::span")));
                femaleRadio.Click();
            }
        }





        public void EnterStreetAddress(string address) => EnterText(FindElement(By.Id("streetaddress")), address);

        public void SelectCountry(string country) => SelectFromDropdown(FindElement(By.Id("country")), country);

        public void EnterZipCode(string zip) => EnterText(FindElement(By.Id("zipcode")), zip);

        public void EnterCity(string city) => EnterText(FindElement(By.Id("city")), city);

        public void SelectOccupation(string occupation) => SelectFromDropdown(FindElement(By.Id("occupation")), occupation);

        public void SelectHobbies(List<string> hobbies)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            foreach (string hobby in hobbies)
            {
                string hobbyId = hobby.ToLower() switch
                {
                    "speeding" => "speeding",
                    "bungee jumping" => "bungeejumping",
                    "cliff diving" => "cliffdiving",
                    "skydiving" => "skydiving",
                    "other" => "other",
                    _ => throw new ArgumentException($"Hobby '{hobby}' não encontrado.")
                };

                IWebElement checkbox = wait.Until(ExpectedConditions.ElementToBeClickable(
                    By.XPath($"//input[@id='{hobbyId}']/following-sibling::span")));

                checkbox.Click();
            }
        }

        public void EnterWebsite(string website) => EnterText(FindElement(By.Id("website")), website);

        public void UploadPicture(string filePath) => FindElement(By.Id("picture")).SendKeys(filePath);

        public void ClickNext() => FindElement(By.Id("nextenterproductdata")).Click();

        public void ValidateSelectedMake(string expectedMake)
        {
            string selectedMake = new SelectElement(FindElement(By.Id("make"))).SelectedOption.Text;
            Assert.AreEqual(expectedMake, selectedMake, "A marca selecionada está incorreta!");
        }

        public void ValidateListPrice()
        {
            string priceText = FindElement(By.Id("listprice")).GetAttribute("value");
            int price = int.Parse(priceText);

            Assert.IsTrue(price >= 5000 && price <= 100000, 
                $"O preço do veículo ({price}) está fora do intervalo permitido (5.000 - 100.000).");
        }
    }

    

}
