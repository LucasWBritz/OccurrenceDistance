using OccurrenceDistance;
using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new ProductsRepository().GetAllProducts();

            var myNewProduct = new Product()
            {
                Name = "Test Product",
                Attributes = new List<ProductAttribute>()
                {
                    new ProductAttribute("A"),
                    new ProductAttribute("C"),
                    new ProductAttribute("D")
                }
            };

            double score = new OcurrenceDistance<string>(products).SimilarityTo(myNewProduct);

            Console.WriteLine("Hello World!");
        }
    }
}
