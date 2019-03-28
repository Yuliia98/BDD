using Lection5SeleniumWD1.Core;
using Lection5SeleniumWD1.PageObjects;
using Lection5SeleniumWD1.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Lection5SeleniumWD1
{
    [TestFixture]
    public class FirstTestSuite
    {
        IWebDriver driver;
        BasicSteps basicSteps;
        CitrusHomePage citrusHomePage;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = DriverSingletone.Driver;
            driver.Manage().Window.Maximize();
            
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Close();
        }

        [Test]
        public void Test1()
        {
            string searchString = "MacBook";
            basicSteps.NavigateToCitrus();
            citrusHomePage.InputInSearchForm(searchString);
            citrusHomePage.ClickToSearchFormSubmitButton();

            Assert.IsTrue(citrusHomePage.VerifyThatAllListItemsContainsSearchStringInTitle(searchString), $"Some items does not contains {searchString} in title");
        }

        [Test]
        public void Test2()
        {

            driver.Navigate().GoToUrl("https://www.citrus.ua");
            IWebElement tvButtonInGeneralMenu = driver.FindElement(By.XPath("//li[contains(@class,'menu-aim__item')]//span[contains(@class,'title')][contains(text(),'Телевизоры')]"));
            tvButtonInGeneralMenu.Click();
            IWebElement lgTvCheckBox = driver.FindElement(By.XPath("(//span[contains(@class,'el-checkbox__input')])[2]"));
            lgTvCheckBox.Click();

            var listOfWebElements = driver.FindElements(By.XPath("//div[contains(@class, 'product-card product-card--mini')]"));
            bool actualResult = listOfWebElements.All(e => e.Text.Contains("LG"));
            Assert.IsTrue(actualResult, "Some items does not contains 'LG' in title");
            IWebElement lgPill = driver.FindElement(By.XPath("//div[contains(@title, 'Бренд: LG')]"));
            bool actualStringResult = lgPill.Text.Contains("LG");
            Assert.IsTrue(actualStringResult, "Pill does not contains LG in title");
        }


        [Test]
        public void Test5()
        {         
            driver.Navigate().GoToUrl(" http://toolsqa.com");
            Actions actions = new Actions(driver);
            WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement demoSitesButton = explicitWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//span[contains(@class, 'menu-text')][contains(text(), 'DEMO SITES')])[1]")));
            actions.MoveToElement(demoSitesButton).Click().Perform();
            IWebElement automationPracticeSwitchWindowsItem = explicitWait.Until(x => x.FindElement(By.XPath("(//span[contains(text(), 'Automation Practice Switch Windows')])[1]")));
            actions.MoveToElement(automationPracticeSwitchWindowsItem).Click().Perform();
            IWebElement newBrowserTabButton = driver.FindElement(By.XPath("//button[contains(text(), 'New Browser Tab')]"));
            newBrowserTabButton.Click();
            ReadOnlyCollection<string> handles= driver.WindowHandles;
            driver.SwitchTo().Window(handles.Last());
            Assert.AreEqual("QA Automation Tools Tutorial", driver.Title);
        }
    }
}
