namespace NewExpressions.Model
{
    public class ProductModel
    {
        public ProductModel() { }

        public ProductModel(string code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
