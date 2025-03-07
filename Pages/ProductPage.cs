using NUnit.Framework.Internal;
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
        public List<Product> GenerateProductListFromUI()
        {
            List<Product> productList = new List<Product>();
            var productContainers = _driver.FindElements(By.ClassName("inventory_item")); // Find all inventory items displayed on the page

            foreach (var productContainer in productContainers)
            {
                try
                {
                    string productTitle = productContainer.FindElement(By.ClassName("inventory_item_name")).Text;
                    string productDescription = productContainer.FindElement(By.ClassName("inventory_item_description")).FindElement(By.ClassName("inventory_item_desc")).Text;
                    string productPrice = productContainer.FindElement(By.ClassName("inventory_item_price")).Text;
                    string productImage = productContainer.FindElement(By.ClassName("inventory_item_img")).FindElement(By.ClassName("inventory_item_img")).GetAttribute("src");

                    Product product = new Product
                    {
                        Title = productTitle,
                        Price = productPrice,
                        Description = productDescription,
                        Image = productImage,
                    };
                    productList.Add(product);
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine($"Error extracting product details: {ex.Message}");
                }
            } //end foreach
            return productList;
        }

        public List<Product> GenerateProductListFromData(){return _data.GetAllProducts();}
        public Product GetProductOnPageByTitle(string title) { return _data.GetProductByTitle(title); }


    }
}
