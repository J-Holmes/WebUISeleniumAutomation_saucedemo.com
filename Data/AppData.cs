using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WebUISeleniumAutomation_saucedemo.com.Data
{
    public class AppData
    {
        private List<Product> _products;
        private DataHelper _dataHelper = new DataHelper();
        public AppData(){LoadProductData();}

        public void LoadProductData() //swap from json to api when built
        {
            _dataHelper.ConvertProductDataToJson();

            try
            {
                string json = File.ReadAllText("Data/productdata.json");
                _products = JsonSerializer.Deserialize<List<Product>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading product data: {ex.Message}");
                _products = new List<Product>(); // Initialize an empty list to avoid null reference issues
            }
        }

        public List<Product> GetAllProducts(){return _products;}
        //public Product GetProductById(string id){return _products.Find(p => p.Id == id);}
        public Product GetProductByTitle(string title){return _products.Find(p => p.Title == title);}
        public Product GetProductByIndex(int index)
        {
            if (index >= 0 && index < _products.Count)
            {
                return _products[index];
            }
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
    }
}
