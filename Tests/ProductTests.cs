using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUISeleniumAutomation_saucedemo.com.Pages;
using NUnit.Framework.Internal;
using WebUISeleniumAutomation_saucedemo.com.Data;
using WebUISeleniumAutomation_saucedemo.com.Pages;

namespace WebUISeleniumAutomation_saucedemo.com.Tests
{
    [TestFixture]
    public class ProductsTest
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;
        private ProductPage _productPage;
        private AppData _data;

        [SetUp]
        public void SetUp()
        {
            // Initialize ChromeDriver
            _driver = new ChromeDriver();

            // Initialize pages
            _loginPage = new LoginPage(_driver);
            _productPage = new ProductPage(_driver);
            _data = new AppData();

            // Log in to the application
            _loginPage.NavigateToLoginPage(ConfigHelper.WebsiteUrl);
            _loginPage.EnterUsername(ConfigHelper.Username);
            _loginPage.EnterPassword(ConfigHelper.Password);
            _loginPage.ClickLoginButton();
        }

        [TearDown]
        public void TearDown()
        {
            // Close the browser and release resources
            _driver?.Quit();
            _driver?.Dispose();
        }

        [Test]
        public void verifyAllProdutTitles() { 
            var allProducts = _data.GetAllProducts();
            foreach (var product in allProducts)
            {
                _productPage.verifyProductTitle(product.Title);
            }   
        }

        //[Test]
        //public void VerifyItemZeroDetailsAndAddToCart()
        //{

        //    string productName = "Sauce Labs Backpack";
        //    string expectedPrice = "$29.99";

        //    // Verify product name
        //    string actualName = _productPage.GetProductName(productName);
        //    Assert.That(actualName, Is.EqualTo(productName), $"Product name is incorrect. Expected: {productName}, Actual: {actualName}");

        //    // Verify product price
        //    string actualPrice = _productPage.GetProductPrice(productName);
        //    Assert.That(actualPrice, Is.EqualTo(expectedPrice), $"Product price is incorrect. Expected: {expectedPrice}, Actual: {actualPrice}");

        //    // Add product to cart
        //    _productPage.AddProductToCart(productName);
        //    Console.WriteLine($"Added {productName} to cart.");
        //}


    }
}
