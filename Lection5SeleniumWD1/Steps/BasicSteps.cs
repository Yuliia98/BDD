using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Lection5SeleniumWD1.Steps
{
    class BasicSteps
    {
        private readonly IWebDriver _driver;
        //public BasicSteps(IWebDriver driver)
        //{
        //    //_driver = driver;
        //    //PageFactory.InitElements(driver, this);
        //}

        public void NavigateToCitrus()
        {
                _driver.Navigate().GoToUrl("https://www.citrus.ua");
        }
    }
}
