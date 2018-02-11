using prismApp.Interfaces;
using prismApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prismApp.Services
{
    public class ProductsService : IProductsService

    {

        public IEnumerable<Product> Getproducts()

        {

            return new List<Product>

            {

                new Product { Name = "Laptop", Price = 1900 },

                new Product { Name = "Iphone", Price = 400 },

            };

        }

    }
}
