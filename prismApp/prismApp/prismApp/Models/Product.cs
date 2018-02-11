using System;
using System.Collections.Generic;
using System.Text;

namespace prismApp.Models
{
    public class Product

    {

        public string Name { get; set; }

        public double Price { get; set; }

        public override string ToString()

        {

            return $"{Name} : {Price} USD";

        }

    }
}
