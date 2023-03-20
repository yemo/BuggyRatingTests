using UIautomation.PageObjects;
using Protractor;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace UIautomation.Steps
{
    [Binding]
    public class HomeStep
    {
        private readonly HomePage _page;
        private readonly ISpecFlowOutputHelper _log;

        public HomeStep(NgWebDriver driver, ISpecFlowOutputHelper outputHelper)
        {
            _page = new HomePage(driver);
            _log = outputHelper;
        }

        [Given(@"I launch buggy rating website")]
        public void ILaunchBuggyRatingWebsite()
        {
            _page.OpenHomePage();
        }

        [Given(@"I go to the popular model page")]
        public void IGoToThePopularModelPage()
        {
            _page.GoToPopularModel();
        }

        [Given(@"I go to the overall page")]
        public void IGoToTheOverallPage()
        {
            _page.GoToOverall();
        }

        [When(@"I go to the register page")]
        public void IGoToTheRegisterPage()
        {
            _page.GoRegister();
        }

        [When(@"I go to the make page")]
        public void IGoToTheMakePage()
        {
            _page.GoToMake();
        }

        [When(@"I enter the invalid username and password")]
        public void IEnterTheInvalidUsernameAndPassword()
        {
            _page.EnterUsername("invalidUser");
            _page.EnterPassword("fake");
            _log.WriteLine("Enter username: invalidUser; password: fake");
            _page.ClickLogin();
        }

        [When(@"I enter the username ""(.*)"" and the password ""(.*)""")]
        public void IEnterTheUsernameAndThePassword(string username, string password)
        {
            _log.WriteLine("Enter username: " + username + "; password: " + password);
            _page.EnterUsername(username);
            _page.EnterPassword(password);
            _page.ClickLogin();
        }

        [Then(@"I assert the warning message is ""(.*)""")]
        public void IAssertTheWarningMessageIs(string msg)
        {
            _log.WriteLine("Verify warning message should be " + msg);
            _page.AssertWarningMsg(msg);
        }

        [Then(@"I assert the greeting message is ""(.*)""")]
        public void IAssertTheGreetingMessageIs(string msg)
        {
            _log.WriteLine("Verify the greeting message should be " + msg);
            _page.AssertGreetingMsg(msg);
        }

        [Then(@"I assert the homepage has successful loaded")]
        public void IAssertTheHomepageHasSuccessfullLoaded()
        {
            _page.AssertCardsLoaded();
        }

    }
}
