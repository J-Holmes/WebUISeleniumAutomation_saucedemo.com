using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebUISeleniumAutomation_saucedemo.com.Pages
{
    class LoginPage //elements & functions for login page
    {
        private readonly IWebDriver _driver;
        public LoginPage(IWebDriver driver) { _driver = driver; }

        // Elements
        private IWebElement UsernameField => _driver.FindElement(By.Id("user-name"));
        private IWebElement PasswordField => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.Id("login-button"));
        private IWebElement ErrorMessage => _driver.FindElement(By.CssSelector("h3"));
        private IWebElement ProductsHeader => _driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/span"));

        // Functions
        public void NavigateToLoginPage(string url) { _driver.Navigate().GoToUrl(url); }
        public void EnterUsername(string username) { UsernameField.SendKeys(username); }
        public void EnterPassword(string password) { PasswordField.SendKeys(password); }
        public void ClickLoginButton() { LoginButton.Click(); }
        public bool IsLoggedIn() { return ProductsHeader.Displayed; }
        public string GetErrorMessage() { return ErrorMessage.Text; }
        public void CloseBrowser() { _driver.Quit(); }

    }
}
