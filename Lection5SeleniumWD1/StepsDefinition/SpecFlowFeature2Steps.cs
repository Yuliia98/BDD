using System;
using TechTalk.SpecFlow;

namespace Lection5SeleniumWD1.StepsDefinition
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        [Given(@"I navigate to (.*)Page")]
        public void GivenINavigateToPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
