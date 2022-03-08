using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutoTest1.Page
{
    public class SushiBasePage
    {
        protected static IWebDriver Driver;

        public SushiBasePage (IWebDriver webDriver)
        {
            Driver = webDriver;
            Driver.Manage().Window.Maximize();
        }
        public WebDriverWait ExplicitWait (int seconds = 3) 
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            return wait;
        }
        public void CloseBrowser()
        {
           Driver.Quit();
        }
    }
}
