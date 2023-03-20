using Protractor;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using UIautomation.PageObjects;

namespace UIautomation.Steps
{
    [Binding]
    public class MakeStep
    {
        private readonly MakePage _page;
        private readonly ISpecFlowOutputHelper _log;

        public MakeStep(NgWebDriver driver, ISpecFlowOutputHelper outputHelper)
        {
            _page = new MakePage(driver);
            _log = outputHelper;
        }

        [When(@"I go back to homepage from the Make page")]
        public void IGoBackToHomepageFromTheMakePage()
        {
            _page.BackToHome();
        }


    }
}
