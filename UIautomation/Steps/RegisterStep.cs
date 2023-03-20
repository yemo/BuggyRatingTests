using UIautomation.PageObjects;
using Protractor;
using TechTalk.SpecFlow;
using UIautomation.Utility;
using TechTalk.SpecFlow.Infrastructure;

namespace UIautomation.Steps
{
    [Binding]
    public class RegisterStep
    {
        private readonly RegisterPage _page;
        private readonly ISpecFlowOutputHelper _log;

        public RegisterStep(NgWebDriver driver, ISpecFlowOutputHelper outputHelper)
        {
            _page = new RegisterPage(driver);
            _log = outputHelper;
        }


        [When(@"I enter random user details on the register page")]
        public void IEnterRandomUserDetails()
        {
            string username = Utility.General.RandomString(10);
            _page.EnterRegisterUserDetail(username);
        }

        [When(@"I click Cancel on the register page")]
        public void IClickCancelOnTheRegisterPage()
        {
            _page.CancelRegister();
        }

        [Given(@"I register a new user and login")]
        public void IRgisterANewUser()
        {
            string username = Utility.General.RandomString(6);
            _page.GoRegister();
            _page.EnterRegisterUserDetail(username);
            _page.ClickRegisterButton();

            _log.WriteLine("Enter username: " + username + "; password: X0yyds!!!!!!!!");
            //add to Scenario Data, for assertion later
            ScenarioContext.Current.Add("UserName", username);
            _page.EnterUsername(username);
            _page.EnterPassword("X0yyds!!!!!!!!");
            _page.ClickLogin();
            _page.AssertGreetingMsg("Hi, " + username);
            _page.BackToHome();
        }
    }
}
