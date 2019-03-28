using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Lection5SeleniumWD1.Core
{
    class DriverFactory
    {
        internal IWebDriver GetDriver (string driverName)
        {
            IWebDriver driver;

            switch (driverName)
            {
                case "chrome":
                    {
                        driver = new ChromeDriver();
                        break;
                    }
                case "firefox":
                    {
                        driver = new FirefoxDriver();
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException(driverName,"This driver does not support" );
            }
            return driver;
        }
    }
}
