using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;

namespace UIautomation.Utility
{
    public class DriverFactory
    {

        public NgWebDriver CreateDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return new NgWebDriver(driver);
        }
    }
}
