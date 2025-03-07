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
        private AppData _data = new AppData();
        private readonly IWebDriver _driver;
        public ProductPage(IWebDriver driver) { _driver = driver; }

        // Functions
        public void getAllProducts (){var allProducts = _data.GetAllProducts();}
        public void getProductById(string id) { var product = _data.GetProductById(id); }
        public bool verifyProductTitle(string id)
        {
            var product = _data.GetProductById(id);
            IWebElement productTitleXPath = _driver.FindElement(By.XPath(product.TitleXPath));
            string uiProductTitle = productTitleXPath.Text;
            return product.Title == uiProductTitle;
        }

        public void CloseBrowser() { _driver.Quit(); }




    }
}
