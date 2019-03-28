using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Lection5SeleniumWD1.Core;

namespace Lection5SeleniumWD1.PageObjects
{
    public class CitrusHomePage
    {
        public  IWebDriver _driver;
        public CitrusHomePage()
        {
            _driver = DriverSingletone.Driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[contains(@type,'search')]")]
        private IWebElement searchForm;
        [FindsBy(How = How.XPath, Using = "//i[contains(@class, 'el-icon-search')]")]
        private IWebElement searchFormSubmitButton;
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'product-card product-card--mini')]")]
        private IList <IWebElement> listOfWebElements;

        public void NavigateToCitrus()
        {
            _driver.Navigate().GoToUrl("https://www.citrus.ua");
        }

        public void InputInSearchForm(string searchString)
        {
            searchForm.SendKeys(searchString);
        }
        public void ClickToSearchFormSubmitButton()
        {
            searchFormSubmitButton.Click();
        }
        public bool VerifyThatAllListItemsContainsSearchStringInTitle(string searchString)
        {
            return listOfWebElements.All(e => e.Text.Contains(searchString)); ;
        }
    }
}
