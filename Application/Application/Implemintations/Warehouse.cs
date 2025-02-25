using Application.Abstractions;

namespace Application.Implemintations
{
    public class Warehouse : IWarehouse
    {
        public Warehouse(List<Product> products)
        {
            Products = products;
        }

        private List<Product> _products;
        public List<Product> Products
        {
            get { return _products; }
            private set { _products = value; }
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
