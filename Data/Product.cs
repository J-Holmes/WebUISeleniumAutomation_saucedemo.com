using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUISeleniumAutomation_saucedemo.com.Data;

namespace WebUISeleniumAutomation_saucedemo.com.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string LinkId { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        //public string? TitleLocator { get; set; }
        //public string? PriceLocator { get; set; }
        //public string? DescriptionLocator { get; set; }
        //public string? ImageLocator { get; set; }
        //public string? AddToCartButtonLocator { get; set; }
    }
}
