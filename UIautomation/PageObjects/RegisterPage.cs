using Protractor;
using OpenQA.Selenium;


namespace UIautomation.PageObjects
{
    public class RegisterPage : HomePage
    {
        private readonly NgWebDriver _driver;
        public RegisterPage(NgWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void EnterRegisterUserDetail(string username)
        {
            txtLogin.SendKeys(username);
            txtFistName.SendKeys(username);
            txtLastName.SendKeys("x0");
            txtPassword.SendKeys("X0yyds!!!!!!!!");
            txtConfirmPassword.SendKeys("X0yyds!!!!!!!!");
        }

        public void CancelRegister()
        {
            btnCancel.Click();
        }

        public void ClickRegisterButton()
        {
            btnRegister.Click();
            _driver.WaitForAngular();
        }

        

        

        public NgWebElement txtLogin => _driver.FindElement(By.XPath("//input[@formcontrolname='username']"));
        public NgWebElement txtFistName => _driver.FindElement(By.XPath("//input[@id='firstName']"));
        public NgWebElement txtLastName => _driver.FindElement(By.XPath("//input[@id='lastName']"));
        public NgWebElement txtPassword => _driver.FindElement(By.XPath("//input[@id='password']"));
        public NgWebElement txtConfirmPassword => _driver.FindElement(By.XPath("//input[@id='confirmPassword']"));
        public NgWebElement btnRegister => _driver.FindElement(By.XPath("//button[contains(.,'Register')]"));
        public NgWebElement btnCancel => _driver.FindElement(By.XPath("//a[contains(.,'Cancel')]"));

    }
}
