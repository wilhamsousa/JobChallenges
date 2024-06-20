using CompositeFactoryLib.Model;
using Xunit.Abstractions;

namespace CompositeFactoryTest
{
    /// <summary>
    /// Component and components list with same interface
    /// Lista encadeada (Linked list) / Object tree 
    /// </summary>
    public class CompositeTest
    {
        private readonly ITestOutputHelper _output;

        public CompositeTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Price()
        {
            var product1 = new Product() { Id = 1, Name = "Product1", Category = "Product", Price = 11.00m };
            var product2 = new Product() { Id = 2, Name = "Product2", Category = "Product", Price = 12.00m };
            var product3 = new Product() { Id = 3, Name = "Product3", Category = "Product", Price = 13.00m };

            var combo1 = new Combo() { Id = 4, Name = "Combo1", Category = "Combo"};
            combo1.AddProduct(product1);
            combo1.AddProduct(product2);
            combo1.AddProduct(product3);

            var product4 = new Product() { Id = 5, Name = "Product4", Category = "Product", Price = 14.00m };
            var product5 = new Product() { Id = 6, Name = "Product5", Category = "Product", Price = 15.00m };
            var product6 = new Product() { Id = 7, Name = "Product6", Category = "Product", Price = 16.00m };

            var combo2 = new Combo() { Id = 3, Name = "Combo2", Category = "Combo" };
            combo2.AddProduct(product4);
            combo2.AddProduct(product5);
            combo2.AddProduct(product6);
            combo2.AddProduct(combo1);

            _output.WriteLine(combo2.GetProductDetails());
            Assert.Equal(11 + 12 + 13 + 14 + 15 + 16, combo2.Price);
        }
    }
}