using AutoTest1.Driver;
using AutoTest1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest1.Test
{
    public class SushiBaseTest
    { 
    public static IWebDriver driver;
    public static SushiOrderPage sushiOrderPage;
    public static SushiMeniuPage sushiMeniuPage;
    public static DrinksMeniuPage drinksMeniuPage;

        [OneTimeSetUp]
        public static void SetUp()
            {
            driver = CustomDriver.GetChromeDriver();
            sushiOrderPage = new SushiOrderPage(driver);
            sushiMeniuPage = new SushiMeniuPage(driver);
            drinksMeniuPage = new DrinksMeniuPage(driver);
            }
        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(driver);
            }
        }

        [OneTimeTearDown]
        public static void TearDown()
            {
            //driver.Quit();
            }
    }
}
