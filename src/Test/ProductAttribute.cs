namespace Test
{
    public class ProductAttribute
    {
        public ProductAttribute(string code)
        {
            Code = code;
        }

        public string Code { get; set; }
    }
}
