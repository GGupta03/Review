/*3 OOP + Collections + Grouping Logic(Manual)
Q3: Product Grouping
Create a Product class with :
Name
Category
Price

Task:
Store products in a List<Product>.
Group products manually by category using:
Dictionary<string, List<Product>>
For each category:
Count number of products
Calculate average price
sort the Product on the bases of Price and 
Print the result.*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }

    public Product(string name, string category, double price)
    {
        Name = name;
        Category = category;
        Price = price;
    }
}

public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product("Laptop", "Electronics", 50000),
            new Product("Mobile", "Electronics", 20000),
            new Product("Table", "Furniture", 7000),
            new Product("Chair", "Furniture", 3000),
            new Product("Pen", "Stationery", 20),
            new Product("Notebook", "Stationery", 50)
        };

        Dictionary<string, List<Product>> groupedProducts = new Dictionary<string, List<Product>>();

        foreach (var prod in products)
        {
            if (!groupedProducts.ContainsKey(prod.Category))
            {
                groupedProducts[prod.Category] = new List<Product>();
            }
            groupedProducts[prod.Category].Add(prod);
        }

        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"Category: {group.Key}");

            List<Product> productList = group.Value;

            int count = productList.Count;

            double avgPrice = productList.Average(p => p.Price);

            productList.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

            Console.WriteLine($" Total Products: {count}");
            Console.WriteLine($" Average Price: {avgPrice}");

            Console.WriteLine($" Products sorted by price:");
            foreach (var p in productList)
            {
                Console.WriteLine($"{p.Name} and {p.Price}");
            }

        }
    }
}

