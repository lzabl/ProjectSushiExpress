using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutoTest1.Driver
{
    public class CustomDriver
    {
        public static IWebDriver GetChromeDriver()
        {
            return GetDriver(BrowsersList.Chrome);
        }

        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(BrowsersList.Firefox);
        }
        private static IWebDriver GetDriver(BrowsersList browser)
        {
            IWebDriver driver = null;
            switch (browser)
            {
                case BrowsersList.Chrome:
                    driver = new ChromeDriver();
                    break;

                case BrowsersList.Firefox:
                    driver = new FirefoxDriver();
                    break;

                default:
                    driver = new ChromeDriver();
                    break;
            }
                driver.Manage().Window.Maximize();
                return driver;
        }
    }
}
