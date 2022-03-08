using AutoTest1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest1.Test
{
    public class SumCalculationTest
    {
        private static IWebDriver driver;

        [OneTimeSetUp]

        public static void Onetimesetup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => d.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
        }
        [OneTimeTearDown]
        public static void Onetimeteardown()
        {
            driver.Quit();
        }

        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a + b = NaN")]
        public static void TestSum(string number1, string number2, string sum)
        {
            SumCalculationPage page = new SumCalculationPage(driver); //naujo objekto kurimas

            page.InsertToFirstField(number1);
            page.InsertToSecondField(number2);
            page.GetResult();
            page.VerifyResult(sum);

        }

    }
}
