using Protractor;
using OpenQA.Selenium;

namespace UIautomation.PageObjects
{
    public class MakePage : HomePage
    {
        private readonly NgWebDriver _driver;
        public MakePage(NgWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

    }
}
