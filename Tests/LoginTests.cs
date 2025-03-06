using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using WebUISeleniumAutomation_saucedemo.com.Pages;  

namespace WebUISeleniumAutomation_saucedemo.com.Tests
{
    [TestFixture]
    class LoginTests
    {
        private ChromeDriver _driver;
        private LoginPage _loginPage;
        //private InventoryPage _inventoryPage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _loginPage = new LoginPage(_driver);
            //_inventoryPage = new InventoryPage(_driver);
        }

        [Test]
        public void Login_WithValidCredentials()
        {
            _loginPage.NavigateToLoginPage(ConfigHelper.WebsiteUrl);
            _loginPage.EnterUsername(ConfigHelper.Username);
            _loginPage.EnterPassword(ConfigHelper.Password);
            _loginPage.ClickLoginButton();
            Assert.That(_loginPage.IsLoggedIn(), Is.True, "Login failed");
            TearDown();
        }

        [Test]
        public void Login_WithInValidCredentials()
        {
            _loginPage.NavigateToLoginPage(ConfigHelper.WebsiteUrl);
            _loginPage.EnterUsername("invalid");
            _loginPage.EnterPassword("invalid");
            _loginPage.ClickLoginButton();
            Assert.That(_loginPage.GetErrorMessage(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"), "Error message is not correct");
            TearDown();
        }

        [TearDown]
        public void TearDown()
        {
            _driver?.Quit(); // Close the browser and end the session
            _driver?.Dispose(); // Release resources        }
        }
    }
}
