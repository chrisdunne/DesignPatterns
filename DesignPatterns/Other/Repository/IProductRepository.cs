using System.Collections.Generic;

namespace DesignPatterns.Other.Repository
{
    public interface IProductRepository
    {
        IProduct GetProduct(int id);

        IEnumerable<IProduct> GetAllProducts();

        IProduct AddProduct(IProduct product);

        IProduct UpdateProduct(IProduct product);

        void DeleteProduct(IProduct product);
    }
}