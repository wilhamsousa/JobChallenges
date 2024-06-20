namespace CompositeFactoryLib.Model.Interface
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        string Category { get; set; }

        string GetProductDetails();
        decimal GetProductPrice();
    }
}
