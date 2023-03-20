using UIautomation.PageObjects;
using Protractor;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace UIautomation.Steps
{
    [Binding]
    public class ModelStep
    {
        private readonly ModelPage _page;
        private readonly ISpecFlowOutputHelper _log;

        public ModelStep(NgWebDriver driver, ISpecFlowOutputHelper outputHelper)
        {
            _page = new ModelPage(driver);
            _log = outputHelper;
        }

        [When(@"I vote the model without comment")]
        public void IVoteTheModelWithoutComment()
        {
            var PrevCount = _page.GetVoteCount();
            ScenarioContext.Current.Add("PrevVoteCount", PrevCount);
            _page.VoteWithoutComment();
        }

        [When(@"I vote the model with comment")]
        public void IVoteTheModelWithComment()
        {
            var comment = Utility.General.RandomString(20);
            ScenarioContext.Current.Add("Comment", comment);
            _log.WriteLine("Posting the comment: " + comment);
            _page.VoteWithComment(comment);
        }

        [Then(@"I verify vote successful")]
        public void IVerifyVoteSuccessful()
        {
            _page.AssertVotedMessage();
        }

        [Then(@"I verify the Author and the comment is displayed in the table list")]
        public void IVerfiyTheCommentIsDisplayedInTheTableList()
        {
            _page.AssertCommentIsDisplayed((string)ScenarioContext.Current["Comment"], (string)ScenarioContext.Current["UserName"]);
        }

        [Then(@"I verfiy vote count is increment")]
        public void IVerfigyVoteCountIsIncrement()
        {
            string PrevCount = (string)ScenarioContext.Current["PrevVoteCount"];
            _page.AssertVoteCountIncrement(PrevCount);
        }
    }
}
