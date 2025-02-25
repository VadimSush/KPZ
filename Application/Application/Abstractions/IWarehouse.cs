using Application.Implemintations;

namespace Application.Abstractions
{
    public interface IWarehouse
    {
        void AddProduct(Product product);

        void RemoveProduct(Product product);

        List<Product> GetProducts();
    }
}
