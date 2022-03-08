using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest1.Page
{
    public class SumCalculationPage
    {
        private static IWebDriver driver; // turi buti private

        private IWebElement firstparam => driver.FindElement(By.Id("sum1"));
        private IWebElement secondparam => driver.FindElement(By.Id("sum2"));
        private IWebElement calculateButton => driver.FindElement(By.CssSelector("#gettotal > button")); // => lambda expression kviecia atributa tik tada, kai jis naudojamas. pvz dalis po => yra ieskoma tik trada, kai 38 eiluteje yra kvieciamas calculateButton kintamasis
        private IWebElement result => driver.FindElement(By.Id("displayvalue"));

        public SumCalculationPage (IWebDriver webDriver) //konstruktorius turi buti public
        {
            driver = webDriver;    
        }

        public void InsertToFirstField(string number1)
        {
            firstparam.Clear();
            firstparam.SendKeys(number1);
        }

        public void InsertToSecondField(string number2)
        {
            secondparam.Clear();
            secondparam.SendKeys(number2);
        }
        public void GetResult ()
        {
            calculateButton.Click();
        }
        public void VerifyResult (string sum)
        {
            Assert.AreEqual(sum, result.Text, "Result is wrong");
        }
      
    }
}
