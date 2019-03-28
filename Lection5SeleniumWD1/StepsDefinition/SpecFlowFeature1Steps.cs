using TechTalk.SpecFlow;
using Lection5SeleniumWD1.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using Lection5SeleniumWD1.Steps;
using Lection5SeleniumWD1.Core;

namespace Lection5SeleniumWD1.StepsDefinition
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        
        CitrusHomePage citrusHomePage = new CitrusHomePage();
         
        [Given(@"I navigate to HomePage")]
        public void GivenINavigateToHomePage()
        {
            citrusHomePage.NavigateToCitrus();
        }
        [Given(@"I have entered '(.*)' in search field")]
        public void GivenIHaveEnteredInSearchField(string searchString)
        {
            citrusHomePage.InputInSearchForm(searchString);
        }
        
        [When(@"I press search button")]
        public void WhenIPressSearchButton()
        {
            citrusHomePage.ClickToSearchFormSubmitButton();
        }
        
        [Then(@"the results contain '(.*)' in title")]
        public void ThenTheResultsContainInTitle(string searchString)
        {
            Assert.IsTrue(citrusHomePage.VerifyThatAllListItemsContainsSearchStringInTitle(searchString), $"Some items does not contains {searchString} in title");
        }
    }
}
