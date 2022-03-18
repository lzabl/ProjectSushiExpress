using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTest1.Page
{
    public class DrinksMeniuPage : SushiBasePage
    {
        private IWebElement drinkMeniu => Driver.FindElement(By.CssSelector("#menu-item-422 > div > a"));
        private IWebElement drinkKombucha => Driver.FindElement(By.CssSelector("#filtered > div.col-lg-4.col-md-6.col-xs-12.post-51145.product.type-product.status-publish.has-post-thumbnail.product_cat-gerimai.last.instock.taxable.shipping-taxable.purchasable.product-type-simple > div"));
        private IWebElement GoBackToMeniu => Driver.FindElement(By.CssSelector("body > main > section > div > div > div.back > a"));
        private IWebElement AddKombuchaToCart => Driver.FindElement(By.CssSelector("#product-51145 > div.main-block.clearfix > div.summary-product.col-md-6.col-sm-6.col-xs-12 > form > button"));

        public DrinksMeniuPage(IWebDriver webdriver) : base(webdriver) { }

        public void GoBackToFullMeniu()
        {
    
            GoBackToMeniu.Click();
        }
        public void OpenDrinksMeniu()
        {
            drinkMeniu.Click();
        }
        public void AddKombucha(string drinkName)
        {
            drinkKombucha.Click();
         
            AddKombuchaToCart.Click();

            string CartContent = Driver.FindElement(By.CssSelector("body > main > section > div > div > div.woocommerce-notices-wrapper > div")).Text;

            Assert.AreEqual(drinkName, CartContent, "Wrong drink added to cart");
        }
    }
}
