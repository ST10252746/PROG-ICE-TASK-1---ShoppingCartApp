using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    // Enum with product categories
    public enum ProductCategory
    {
        Clothing,
        Electronics,
        Home,
        Beauty,
        Groceries
    }

    public class Product
    {
        // Attributes - private variables within the Product Class
        private string name; // Stores name of product
        private double price; // Stores price of product
        private ProductCategory category; // Store the category of a product from enum

        // Public properties accessed outside of class
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public ProductCategory Category { get { return category; } }

        // Constructor method with parameters
        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        // Method to display the information
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Price: {price}, Category: {category}");
        }
    }
}