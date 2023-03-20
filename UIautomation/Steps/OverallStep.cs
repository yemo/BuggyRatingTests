using UIautomation.PageObjects;
using Protractor;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace UIautomation.Steps
{
    [Binding]
    public class OverallStep
    {
        private readonly OverallPage _page;
        private readonly ISpecFlowOutputHelper _log;

        public OverallStep(NgWebDriver driver, ISpecFlowOutputHelper outputHelper)
        {
            _page = new OverallPage(driver);
            _log = outputHelper;
        }

        [Given(@"I select the model ""(.*)"" on overall page")]
        public void ISelectTheModelOnOverallPage(string model)
        {
            _page.SelectModel(model);
        }
    }
}
