using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebUISeleniumAutomation_saucedemo.com.Data
{
    //this class is to help convert data from C# to JSON for temp use while building the backend
    class DataHelper
    {
        public void ConvertProductDataToJson()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 0,
                    LinkId = "item_0_title_link",
                    Title = "Sauce Labs Bike Light",
                    Price = "$9.99",
                    Description = "A red light isn't the desired state in testing but it sure helps when riding your bike at night. Water-resistant with 3 lighting modes, 1 AAA battery included.",
                    Image = "https://www.saucedemo.com/static/media/bike-light-1200x1500.37c843b0.jpg",
                },
                new Product
                {
                    Id = 1,
                    LinkId = "item_1_title_link",
                    Title = "Sauce Labs Bolt T-Shirt",
                    Price = "$15.99",
                    Description = "Get your testing superhero on with the Sauce Labs bolt T-shirt. From American Apparel, 100% ringspun combed cotton, heather gray with red bolt.",
                    Image = "https://www.saucedemo.com/static/media/bolt-shirt-1200x1500.c2599ac5.jpg",
                },
                new Product
                {
                    Id = 2,
                    LinkId = "item_2_title_link",
                    Title = "Sauce Labs Onesie",
                    Price = "$7.99",
                    Description = "Rib snap infant onesie for the junior automation engineer in development. Reinforced 3-snap bottom closure, two-needle hemmed sleeved and bottom won't unravel.",
                    Image = "https://www.saucedemo.com/static/media/red-onesie-1200x1500.2ec615b2.jpg",
                },
                new Product
                {
                    Id = 3,
                    LinkId = "item_3_title_link",
                    Title = "Test.allTheThings() T-Shirt (Red)",
                    Price = "$15.99",
                    Description = "This classic Sauce Labs t-shirt is perfect to wear when cozying up to your keyboard to automate a few tests. Super-soft and comfy ringspun combed cotton.",
                    Image = "https://www.saucedemo.com/static/media/red-tatt-1200x1500.30dadef4.jpg",
                },
                new Product
                {
                    Id = 4,
                    LinkId = "item_4_title_link",
                    Title = "Sauce Labs Backpack",
                    Price = "$29.99",
                    Description = "carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.",
                    Image = "https://www.saucedemo.com/static/media/sauce-backpack-1200x1500.0a0b85a3.jpg",
                },
                new Product
                {
                    Id = 5,
                    LinkId = "item_5_title_link",
                    Title = "Sauce Labs Fleece Jacket",
                    Price = "$49.99",
                    Description = "It's not every day that you come across a midweight quarter-zip fleece jacket capable of handling everything from a relaxing day outdoors to a busy day at the office.",
                    Image = "https://www.saucedemo.com/static/media/sauce-pullover-1200x1500.51d7ffaf.jpg",
                }
            };
            string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = false });
            string filePath = Path.Combine("Data", "productdata.json");
            File.WriteAllText(filePath, json);
        }

    }
}
