using prismApp.Interfaces;
using prismApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prismApp.ViewModel
{
    public class ProductsViewModel

    {

        private readonly IProductsService _productsService;

        



        public IEnumerable<Product> Products { get; set; }



        public ProductsViewModel(IProductsService productsService)

        {

            _productsService = productsService;

           

            DownloadProducts();

            

        }

        public void DownloadProducts()

        {

            Products = _productsService.Getproducts();

        }

    }
}
