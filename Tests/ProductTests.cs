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
        private List<Product> _productListFromUI;
        private List<Product> _productListFromData;

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
            _data.LoadProductData();

            //Initialize Variables
            _productListFromUI = new List<Product>();
            _productListFromData = new List<Product>();

            //Initialize Data
            _productListFromUI = _productPage.GenerateProductListFromUI();
            _productListFromData = _data.GetAllProducts();
        }

        [TearDown]
        public void TearDown()
        {
            // Close the browser and release resources
            _driver?.Quit();
            _driver?.Dispose();
        }

        [Test] //test price match for item 0
        public void verifyPriceOfItemZero()
        {
            var itemZeroData = _productListFromData[0];
            var itemZeroUI = _productListFromUI.FirstOrDefault(p => p.Title == itemZeroData.Title);
            Assert.That(itemZeroData.Price, Is.EqualTo(itemZeroUI.Price));
        }

        [Test] //test price match for item 1
        public void verifyPriceOfItemOne() {
            var itemOneData = _productListFromData[1];
            var itemOneUI = _productListFromUI.FirstOrDefault(p => p.Title == itemOneData.Title);
            Assert.That(itemOneData.Price, Is.EqualTo(itemOneUI.Price));
        }

        [Test] //test price match for item 2
        public void verifyPriceOfItemTwo() {
            var itemTwoData = _productListFromData[2];
            var itemTwoUI = _productListFromUI.FirstOrDefault(p => p.Title == itemTwoData.Title);
            Assert.That(itemTwoData.Price, Is.EqualTo(itemTwoUI.Price));
        }
        
        [Test] //test price match for item 3
        public void verifyPriceOfItemThree() {
            var itemThreeData = _productListFromData[3];
            var itemThreeUI = _productListFromUI.FirstOrDefault(p => p.Title == itemThreeData.Title);
            Assert.That(itemThreeData.Price, Is.EqualTo(itemThreeUI.Price));
        }

        [Test] //test price match for item 4
        public void verifyPriceOfItemFour()
        {
            var itemFourData = _productListFromData[4];
            var itemFourUI = _productListFromUI.FirstOrDefault(p => p.Title == itemFourData.Title);
            Assert.That(itemFourData.Price, Is.EqualTo(itemFourUI.Price));
        }

        [Test] //test price match for item 5
        public void verifyPriceOfItemFive()
        {
            var itemFiveData = _productListFromData[5];
            var itemFiveUI = _productListFromUI.FirstOrDefault(p => p.Title == itemFiveData.Title);
            Assert.That(itemFiveData.Price, Is.EqualTo(itemFiveUI.Price));
        }

        [Test]//test description match for item 0
        public void verifyDescriptionOfItemZero()
        {
            var itemZeroData = _productListFromData[0];
            var itemZeroUI = _productListFromUI.FirstOrDefault(p => p.Title == itemZeroData.Title);
            Assert.That(itemZeroData.Description, Is.EqualTo(itemZeroUI.Description));
        }

        [Test]//test description match for item 1
        public void verifyDescriptionOfItemOne() {
            var itemOneData = _productListFromData[1];
            var itemOneUI = _productListFromUI.FirstOrDefault(p => p.Title == itemOneData.Title);
            Assert.That(itemOneData.Description, Is.EqualTo(itemOneUI.Description));
        }

        [Test]//test description match for item 2
        public void verifyDescriptionOfItemTwo()
        {
            var itemTwoData = _productListFromData[2];
            var itemTwoUI = _productListFromUI.FirstOrDefault(p => p.Title == itemTwoData.Title);
            Assert.That(itemTwoData.Description, Is.EqualTo(itemTwoUI.Description));
        }

        [Test]//test description match for item 3
        public void verifyDescriptionOfItemThree() {
            var itemThreeData = _productListFromData[3];
            var itemThreeUI = _productListFromUI.FirstOrDefault(p => p.Title == itemThreeData.Title);
            Assert.That(itemThreeData.Description, Is.EqualTo(itemThreeUI.Description));
        }

        [Test]//test description match for item 4
        public void verifyDescriptionOfItemFour() {
            var itemFourData = _productListFromData[4];
            var itemFourUI = _productListFromUI.FirstOrDefault(p => p.Title == itemFourData.Title);
            Assert.That(itemFourData.Description, Is.EqualTo(itemFourUI.Description));
        }

        [Test]//test description match for item 5
        public void verifyDescriptionOfItemFive()
        {
            var itemFiveData = _productListFromData[5];
            var itemFiveUI = _productListFromUI.FirstOrDefault(p => p.Title == itemFiveData.Title);
            Assert.That(itemFiveData.Description, Is.EqualTo(itemFiveUI.Description));
        }

        [Test]//test image match for item 0
        public void verifyImageOfItemZero()
        {
            var itemZeroData = _productListFromData[0];
            var itemZeroUI = _productListFromUI.FirstOrDefault(p => p.Title == itemZeroData.Title);
            Assert.That(itemZeroData.Image, Is.EqualTo(itemZeroUI.Image));
        }

        [Test]//test image match for item 1
        public void verifyImageOfItemOne() {
            var itemOneData = _productListFromData[1];
            var itemOneUI = _productListFromUI.FirstOrDefault(p => p.Title == itemOneData.Title);
            Assert.That(itemOneData.Image, Is.EqualTo(itemOneUI.Image));
        }

        [Test]//test image match for item 2
        public void verifyImageOfItemTwo()
        {
            var itemTwoData = _productListFromData[2];
            var itemTwoUI = _productListFromUI.FirstOrDefault(p => p.Title == itemTwoData.Title);
            Assert.That(itemTwoData.Image, Is.EqualTo(itemTwoUI.Image));
        }

        [Test]//test image match for item 3
        public void verifyImageOfItemThree()
        {
            var itemThreeData = _productListFromData[3];
            var itemThreeUI = _productListFromUI.FirstOrDefault(p => p.Title == itemThreeData.Title);
            Assert.That(itemThreeData.Image, Is.EqualTo(itemThreeUI.Image));
        }

        [Test]//test image match for item 4
        public void verifyImageOfItemFour() {
            var itemFourData = _productListFromData[4];
            var itemFourUI = _productListFromUI.FirstOrDefault(p => p.Title == itemFourData.Title);
            Assert.That(itemFourData.Image, Is.EqualTo(itemFourUI.Image));
        }

        [Test]//test image match for item 5
        public void verifyImageOfItemFive()
        {
            var itemFiveData = _productListFromData[5];
            var itemFiveUI = _productListFromUI.FirstOrDefault(p => p.Title == itemFiveData.Title);
            Assert.That(itemFiveData.Image, Is.EqualTo(itemFiveUI.Image));
        }
    }
}
