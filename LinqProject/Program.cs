﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

List<Category> categories = new List<Category>
  {
    new Category{CategoryId=1, CategoryName="Bilgisayar"},
    new Category{CategoryId=2, CategoryName="Telefon"},
    };
List<Product> products = new List<Product>
{
     new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=5},
     new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=8000, UnitsInStock=3},
     new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=6000, UnitsInStock=2},
     new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon", QuantityPerUnit="4 GB RAM", UnitPrice=5000, UnitsInStock=15},
     new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon", QuantityPerUnit="4 GB RAM", UnitPrice=8000, UnitsInStock=0},

};

//Test(products);
//AnyTest(products); bir listenin içersinde eleman var mı yok mu ara?
//FindTest(products); ürünün detayına gitmek için
//FindAllTest(products); where gibi koşul sağlar
//AscDescTest(products); detaylı sıralama
//ClassicLinqTest(products);

var result = from p in products
             join c in categories
             on p.CategoryId equals c.CategoryId
             where p.UnitPrice >5000
             orderby p.UnitPrice descending
             select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
foreach (var productDto in result)
{
    Console.WriteLine("{0} --- {1}", productDto.ProductName, productDto.CategoryName);
}






//Linq gerçek hayat
static List<Product> GetProductsLinq(List<Product> products)
{
    return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
}

static void Test(List<Product> products)
{
    Console.WriteLine("Algoritmik...............");

    foreach (var product in products)
    {
        if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
        {
            Console.WriteLine(product.ProductName);
        }
    }


    Console.WriteLine("Linqq-----------------");
    var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
    foreach (var p in result)
    {
        Console.WriteLine(p.ProductName);
    }
}

static void AnyTest(List<Product> products)
{
    var result = products.Any(p => p.ProductName == "Acer Laptop");
    Console.WriteLine(result);
}

static void FindTest(List<Product> products)
{
    var result = products.Find(p => p.ProductId == 3);
    Console.WriteLine(result.ProductName);
}

static void FindAllTest(List<Product> products)
{
    var result = products.FindAll(p => p.ProductName.Contains("top"));
    Console.WriteLine(result);
}

static void NewMethod(List<Product> products)
{
    var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
    foreach (var product in result)
    {
        Console.WriteLine(product.ProductName);
    }
}

static void ClassicLinqTest(List<Product> products)
{
    var result = from p in products
                 where p.UnitPrice > 6000
                 orderby p.UnitPrice descending, p.ProductName descending
                 select new ProductDto { ProductName = p.ProductName, ProductId = p.ProductId, UnitPrice = p.UnitPrice, };
    foreach (var product in result)
    {
        Console.WriteLine(product.ProductName);
    }
}

class ProductDto
{

    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public string CategoryName { get; set; }
}

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    public int CategoryId { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}