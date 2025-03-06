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
        public string Id { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TitleXPath { get; set; }
        public string PriceXPath { get; set; }
        public string DescriptionXPath { get; set; }
        public string ImageXPath { get; set; }
        public string AddToCartButtonXPath { get; set; }

    }
}
