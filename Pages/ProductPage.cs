using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUISeleniumAutomation_saucedemo.com.Data;

namespace WebUISeleniumAutomation_saucedemo.com.Pages
{
    class ProductPage //elements & functions for products page
    {
        private readonly IWebDriver _driver;
        public ProductPage(IWebDriver driver) { _driver = driver; }
        private AppData _data = new AppData();

        // Elements
        private IWebElement SauceLabsBackpackLabel => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBackpackImage => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBackpackPrice => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBackpackDescription => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBackpackAddToCartButton => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBikeLightLabel => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBikeLightImage => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBikeLightPrice => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBikeLightDescription => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBikeLightAddToCartButton => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBoltTShirtLabel => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBoltTShirtImage => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBoltTShirtPrice => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBoltTShirtDescription => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsBoltTShirtAddToCartButton => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsFleeceJacketLabel => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsFleeceJacketImage => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsFleeceJacketPrice => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsFleeceJacketDescription => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsFleeceJacketAddToCartButton => _driver.FindElement(By.XPath(""));
        private IWebElement TestAllTheThingsTShirtRedLabel => _driver.FindElement(By.XPath(""));
        private IWebElement TestAllTheThingsTShirtRedImage => _driver.FindElement(By.XPath(""));
        private IWebElement TestAllTheThingsTShirtRedPrice => _driver.FindElement(By.XPath(""));
        private IWebElement TestAllTheThingsTShirtRedDescription => _driver.FindElement(By.XPath(""));
        private IWebElement TestAllTheThingsTShirtRedAddToCartButton => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsOnesieLabel => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsOnesieImage => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsOnesiePrice => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsOnesieDescription => _driver.FindElement(By.XPath(""));
        private IWebElement SauceLabsOnesieAddToCartButton => _driver.FindElement(By.XPath(""));






        // Functions
        public bool verifyProductTitle(string id)
        {
            var product = _data.GetProductById(id);
            IWebElement productTitleXPath = _driver.FindElement(By.XPath(product.TitleXPath));
            string uiProductTitle = productTitleXPath.Text;
            return product.Title == uiProductTitle;
        }

        public void CloseBrowser() { _driver.Quit(); }
        public void verifySauceLabsBackpackLabel(){SauceLabsBackpackLabel.Displayed.Equals(true);}
        public void verifySauceLabsBackpackImage() { SauceLabsBackpackImage.Displayed.Equals(true); }
        public void verifySauceLabsBackpackPrice() { SauceLabsBackpackPrice.Displayed.Equals(true); }
        public void verifySauceLabsBackpackDescription() { SauceLabsBackpackDescription.Displayed.Equals(true); }
        public void AddSauceLabsBackpackToCart() { SauceLabsBackpackAddToCartButton.Click(); }



    }
}
