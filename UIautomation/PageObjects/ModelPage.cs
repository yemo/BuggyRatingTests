using FluentAssertions;
using OpenQA.Selenium;
using Protractor;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIautomation.PageObjects
{
    public class ModelPage : HomePage
    {
        private readonly NgWebDriver _driver;
        public ModelPage(NgWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void VoteWithoutComment()
        {
            btnVote.Click();
            _driver.WaitForAngular();
        }

        public void VoteWithComment(string comment)
        {
            txtComment.SendKeys(comment);
            btnVote.Click();
            _driver.WaitForAngular();
        }

        public void AssertVotedMessage()
        {
            lblVoteCardText.Text.Should().Be("Thank you for your vote!");
        }

        public void AssertCommentIsDisplayed(string comment,string author)
        {
            IList<NgWebElement> listElements = _driver.FindElements(By.XPath("//td[contains(.,'" + comment + "')]"));
            listElements.Count.Should().Be(1);
            if (listElements.Count > 0)
            {
                NgWebElement lblAuthor = _driver.FindElement(By.XPath("//tr[./td[contains(.,'" + comment + "')]]/td[2]"));
                lblAuthor.Text.Should().Be(author);
            }
        }

        public NgWebElement txtComment => _driver.FindElement(By.XPath("//textarea[@id='comment']"));
        public NgWebElement btnVote => _driver.FindElement(By.XPath("//button[contains(.,'Vote!')]"));
        public NgWebElement lblVoteCardText => _driver.FindElement(By.XPath("//p[@class='card-text']"));
    }
}
