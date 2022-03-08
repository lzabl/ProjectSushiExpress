using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest1.Page
{
    public class SushiMeniuPage : SushiBasePage
    {
        private const string PageAddress = "https://sushiexpress.lt/";
        private IWebElement MeniuPage => Driver.FindElement(By.Id("menu-item-311"));
        private IWebElement SushiMeniu => Driver.FindElement(By.Id("menu-item-417"));
       
        public SushiMeniuPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
        }

        public void OpenFullMeniu()
        {
            MeniuPage.Click();
        }
        public void OpenSushiMeniuPage()
        {
            SushiMeniu.Click();
        }
        public void FaveSushiCheckboxes(string sushiType)
        {
            IWebElement Checkbox1 = Driver.FindElement(By.XPath("//label[text()='Nigiri']"));

            Checkbox1.Click();
            string Nigiri = Driver.FindElement(By.XPath("//label[text()='Nigiri']")).Text;

            Assert.AreEqual(sushiType, Nigiri, "Wrong sushi was checked");
        }
    }
}
