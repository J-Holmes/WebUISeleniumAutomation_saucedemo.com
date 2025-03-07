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

        //test title 0
        public void verifyItemZeroTitle () //separate test data and product data for compar
        {
            _productPage.getProductById("0");

        }
           
        //test title 1
        //test title 2
        //test title 3
        //test title 4
        //test title 5
        //test title 6



    }
}
