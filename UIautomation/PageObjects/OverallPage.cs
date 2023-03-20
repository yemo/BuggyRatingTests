using Protractor;
using OpenQA.Selenium;

namespace UIautomation.PageObjects
{
    public class OverallPage : HomePage
    {
        private readonly NgWebDriver _driver;
        public OverallPage(NgWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void SelectModel(string model)
        {
            NgWebElement selected = _driver.FindElement(By.XPath("//a[contains(.,'" + model + "')]"));
            selected.Click();
            _driver.WaitForAngular();
        }
    }
}
