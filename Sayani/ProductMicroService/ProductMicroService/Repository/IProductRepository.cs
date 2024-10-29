
using ProductMicroService.Models;

namespace ProductMicroService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductByID(int id);

        void InsertProduct(Product product);

        void DeleteProduct(int productid);

        void UpdateProduct(Product product);

        void Save();

    }
}
