using TechTalk.SpecFlow;
using Lection5SeleniumWD1.Core;
using Lection5SeleniumWD1.PageObjects;
using Lection5SeleniumWD1.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Lection5SeleniumWD1.Hooks
{
    [Binding]
    public sealed class InitializeDriver
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        IWebDriver driver;
         
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = DriverSingletone.Driver;
            driver.Manage().Window.Maximize();
             
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();//TODO: implement logic that has to run after executing each scenario
        }
    }
}
