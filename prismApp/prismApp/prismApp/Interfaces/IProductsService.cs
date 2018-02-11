using prismApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace prismApp.Interfaces
{
    public interface IProductsService

    {

        IEnumerable<Product> Getproducts();

    }
}
