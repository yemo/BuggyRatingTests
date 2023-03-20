using FluentAssertions;
using OpenQA.Selenium;
using Protractor;


namespace UIautomation.PageObjects
{
    public class HomePage
    {
        private readonly NgWebDriver _driver;

        public HomePage(NgWebDriver driver)
        {
            _driver = driver;
        }

        public void OpenHomePage()
        {
            _driver.Navigate().GoToUrl("https://buggy.justtestit.org/");
        }

        public void GoRegister()
        {
            btnRegisterPage.Click();
            _driver.WaitForAngular();
        }

        public void GoMake()
        {
            lnkMake.Click();
            _driver.WaitForAngular();
        }

        public void GoModel()
        {
            lnkModel.Click();
            _driver.WaitForAngular();
        }

        public void GoOverall()
        {
            lnkOverall.Click();
            _driver.WaitForAngular();
        }

        public string Get1stCardHeader()
        {
            return lbl1stCard.Text;
        }

        public void EnterUsername(string username)
        {
            txtLoginName.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            txtLoginPw.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
            _driver.WaitForAngular();
        }

        public void AssertWarningMsg(string msg)
        {
            string displayMsg = lblWarning.Text;
            displayMsg.Should().Be(msg);
        }

        public void AssertGreetingMsg(string msg)
        {
            string displayMsg = lblGreeting.Text;
            displayMsg.Should().Be(msg);
        }

        public void AssertCardsLoaded()
        {
            lbl1stCard.Text.Should().Be("Popular Make");
            lbl2ndCard.Text.Should().Be("Popular Model");
            lbl3rdCard.Text.Should().Be("Overall Rating");
        }

        public void GoToPopularModel()
        {
            lnkModel.Click();
            _driver.WaitForAngular();
        }

        public void GoToMake()
        {
            lnkMake.Click();
            _driver.WaitForAngular();
        }

        public void GoToOverall()
        {
            lnkOverall.Click();
            _driver.WaitForAngular();
        }

        public void BackToHome()
        {
            logo.Click();
            _driver.WaitForAngular();
        }


        public NgWebElement btnRegisterPage => _driver.FindElement(By.XPath("//a[@href='/register']"));
        public NgWebElement lnkMake => _driver.FindElement(By.XPath(".//my-home/div/div[1]/div[@class='card']/a"));
        public NgWebElement lbl1stCard => _driver.FindElement(By.XPath(".//my-home/div/div[1]/div[@class='card']/h2"));
        public NgWebElement lnkModel => _driver.FindElement(By.XPath(".//my-home/div/div[2]/div[@class='card']/a"));
        public NgWebElement lbl2ndCard => _driver.FindElement(By.XPath(".//my-home/div/div[2]/div[@class='card']/h2"));
        public NgWebElement lnkOverall => _driver.FindElement(By.XPath(".//my-home/div/div[3]/div[@class='card']/a"));
        public NgWebElement lbl3rdCard => _driver.FindElement(By.XPath(".//my-home/div/div[3]/div[@class='card']/h2"));
        public NgWebElement txtLoginName => _driver.FindElement(By.XPath("//input[@name='login']"));
        public NgWebElement txtLoginPw => _driver.FindElement(By.XPath("//input[@name='password']"));
        public NgWebElement btnLogin => _driver.FindElement(By.XPath("//button[@type='submit']"));
        public NgWebElement imgLoading => _driver.FindElement(By.XPath("//img[@src='/img/spin.gif']"));
        public NgWebElement lblWarning => _driver.FindElement(By.XPath("//span[@class='label label-warning']"));
        public NgWebElement lblGreeting => _driver.FindElement(By.XPath("//my-login/div/ul/li[1]/span"));
        public NgWebElement logo => _driver.FindElement(By.XPath("//a[@class='navbar-brand']"));
    }
}
