using CompositeFactoryLib.Model.Interface;

namespace CompositeFactoryLib.Model
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public string GetProductDetails()
        {
            return $"Name {Name} Category {Category} Price {Price}";
        }

        public decimal GetProductPrice()
        {
            return Price;
        }
    }
}
