using System.Collections.Generic;

namespace Test
{
    public class ProductsRepository
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                Name = "Product A",
                Attributes = new List<ProductAttribute>()
                {
                    new ProductAttribute("A"),
                    new ProductAttribute("B"),
                    new ProductAttribute("C"),
                    new ProductAttribute("D"),
                    new ProductAttribute("E"),
                }
            });
            products.Add(new Product()
            {
                Name = "Product B",
                Attributes = new List<ProductAttribute>()
                {
                    new ProductAttribute("A"),
                    new ProductAttribute("B"),
                    new ProductAttribute("C")
                }
            });
            products.Add(new Product()
            {
                Name = "Product C",
                Attributes = new List<ProductAttribute>()
                {                    
                    new ProductAttribute("B"),
                    new ProductAttribute("C"),
                    new ProductAttribute("D")                   
                }
            });
            products.Add(new Product()
            {
                Name = "Product D",
                Attributes = new List<ProductAttribute>()
                {
                    new ProductAttribute("A"),
                    new ProductAttribute("E"),
                }
            });
            products.Add(new Product()
            {
                Name = "Product A",
                Attributes = new List<ProductAttribute>()
                {
                    new ProductAttribute("B"),
                    new ProductAttribute("C"),
                    new ProductAttribute("E")
                }
            });

            return products;
        }
    }
}
