using CompositeFactoryLib.Model.Interface;

namespace CompositeFactoryLib.Model
{
    public class Combo : IProduct
    {
        private readonly List<IProduct> _subProducts;

        public Combo()
        {
            _subProducts = new List<IProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get => GetProductPrice(); set => SetProductPrice(value); }
        public string Category { get; set; }

        public string GetProductDetails()
        {
            var result = string.Empty;
            result += $"Name {Name} Category {Category} Price {Price} \n";
            result += "All the products: \n";

            foreach (var product in _subProducts)
                result += product.GetProductDetails() + "\n";

            return result;
        }

        public decimal GetProductPrice()
        {
            decimal price = 0;

            foreach (var product in _subProducts)
                price += product.Price;

            return price;
        }

        public decimal SetProductPrice(decimal price) => throw new NotImplementedException();

        public void AddProduct(IProduct product)
        {
            _subProducts.Add(product);
        }
    }
}
