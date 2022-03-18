using AutoTest1.Driver;
using AutoTest1.Page;
using AutoTest1.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

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
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }

    }
}
