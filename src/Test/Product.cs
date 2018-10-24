using OccurrenceDistance;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class Product : IDistanciable<string>
    {
        public Product()
        {
            Attributes = new List<ProductAttribute>();
        }

        public string Name { get; set; }

        public IEnumerable<ProductAttribute> Attributes { get; set; }

        public string[] GetDistanciableItems()
        {
            return Attributes.Select(x => x.Code).ToArray();
        }
    }
}
