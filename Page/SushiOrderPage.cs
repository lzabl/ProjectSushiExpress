using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;


namespace AutoTest1.Page
{
    public class SushiOrderPage : SushiBasePage
    {
        private IWebElement sushiKappaMaki => Driver.FindElement(By.CssSelector("#filtered > div.col-lg-4.col-md-6.col-xs-12.post-443.product.type-product.status-publish.has-post-thumbnail.product_cat-susiai.product_cat-vegetariski.first.instock.taxable.shipping-taxable.purchasable.product-type-simple > div"));
        private IWebElement sushiCalifornia => Driver.FindElement(By.CssSelector("#filtered > div.col-lg-4.col-md-6.col-xs-12.post-485.product.type-product.status-publish.has-post-thumbnail.product_cat-su-krabu-lazdelemis.product_cat-susiai.product_cat-top-prekes.last.instock.taxable.shipping-taxable.purchasable.product-type-simple > div"));
        private IWebElement addToCart => Driver.FindElement(By.CssSelector(".single_add_to_cart_button"));
        private IWebElement cart => Driver.FindElement(By.CssSelector("#header > div > div > div:nth-child(2) > div > div.top-mini-cart > a"));
        private IWebElement quantityPlus => Driver.FindElement(By.ClassName("quantity-plus"));
        public SushiOrderPage(IWebDriver webdriver) : base(webdriver) { }
      
        public void VerifyPrice (string price)
        {
            string sushiKappaMakiPrice = Driver.FindElement(By.CssSelector("#filtered > div.col-lg-4.col-md-6.col-xs-12.post-443.product.type-product.status-publish.has-post-thumbnail.product_cat-susiai.product_cat-vegetariski.first.instock.taxable.shipping-taxable.purchasable.product-type-simple > div > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link > span > span > bdi")).Text;
            Assert.AreEqual(price, sushiKappaMakiPrice, "Price is wrong");
        }

        public void AddToCart2xnr1(string amount) //++ 
        {
            sushiKappaMaki.Click();

            IWebElement kiekis = Driver.FindElement(By.CssSelector("#product-443 > div.main-block.clearfix > div.summary-product.col-md-6.col-sm-6.col-xs-12 > form > div > input"));
            kiekis.Click(); 
            kiekis.Clear();
            kiekis.SendKeys("2"); 
            addToCart.Click();

            string cartContent = Driver.FindElement(By.CssSelector("#header > div > div > div:nth-child(2) > div > div.top-mini-cart > a")).Text;

            Assert.AreEqual(amount, cartContent, "Wrong amount added to cart");

        }
        public void AddToCartNr18() //++
        {
            sushiCalifornia.Click();
            addToCart.Click();
           
        }
        public void ChangeQuantity(string message) //++
        {
            cart.Click();
            quantityPlus.Click();

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(d => d.FindElement(By.CssSelector("body > main > section > div > div > div > div > div.woocommerce-notices-wrapper > div")).Displayed);
          
            string updateMessage = Driver.FindElement(By.CssSelector("body > main > section > div > div > div > div > div.woocommerce-notices-wrapper > div")).Text;
          
            Assert.AreEqual(message, updateMessage, "Wrong message appeared");
        }

    }

}


