using OpenQA.Selenium;

namespace Lection5SeleniumWD1.Core
{
    class DriverSingletone
    {
        public static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                    if(_driver == null)
                    {
                        _driver = new DriverFactory().GetDriver("chrome");
                    }
                return _driver;
            }
        }
    }
}
