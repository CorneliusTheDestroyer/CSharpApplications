using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace PracticeApp05
{
    class Program
    {
        public class AppDbContext : DbContext
        {
            public DbSet<Product> Products { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=dazzler\\sql2022;Database=Test_CS;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }

            public void Create()
            {
                using (var context = new AppDbContext())
                {
                    var product = new Product
                    {
                        Name = "Laptop",
                        Price = 1200.50m
                    };
                    //var product = new Product
                    //{
                    //    Name = "Desktop",
                    //    Price = 2200.00m
                    //};
                    //var product = new Product
                    //{
                    //    Name = "Tablet",
                    //    Price = 550.50m
                    //};

                    context.Products.Add(product);
                    context.SaveChanges();
                    Console.WriteLine("Product added successfully!");
                }
            }

            public void GetAllProducts()
            {
                using (var context = new AppDbContext())
                {
                    var products = context.Products.ToList();
                    foreach (var product in products)
                    {
                        Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                    }
                }
            }

            public void GetProductByID()
            {
                using (var context = new AppDbContext())
                {
                    var product = context.Products.FirstOrDefault(p => p.Id == 1);
                    if (product != null)
                    {
                        Console.WriteLine($"Found: {product.Name} - ${product.Price}");
                    }
                    else
                    {
                        Console.WriteLine("Product not found!");
                    }
                }
            }

            public void UpdateProduct()
            {
                using (var context = new AppDbContext())
                {
                    var product = context.Products.FirstOrDefault(p => p.Id == 1);
                    if (product != null)
                    {
                        product.Price = 1300.00m;
                        context.SaveChanges();
                        Console.WriteLine("Product updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Product not found!");
                    }
                }
            }

            public void DeleteProduct()
            {
                using (var context = new AppDbContext())
                {
                    var product = context.Products.FirstOrDefault(p => p.Id == 1);
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                        Console.WriteLine("Product deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Product not found!");
                    }
                }
            }
        }

        static void Main()
        {
            Product product = new Product();
            //product.Create();
            product.GetAllProducts();

            Console.WriteLine("-------------------------");

            //product.GetProductByID();

            //Console.WriteLine("-------------------------");

            //product.UpdateProduct();
            //product.GetProductByID();
            //product.DeleteProduct();
            //product.GetAllProducts();

            Console.WriteLine("-------------------------");
        }
    }
}

