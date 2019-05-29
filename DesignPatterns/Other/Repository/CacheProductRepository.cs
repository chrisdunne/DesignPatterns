using System;
using System.Collections.Generic;

namespace DesignPatterns.Other.Repository
{
    public class CacheProductRepository : IProductRepository
    {
        public IProduct AddProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IProduct GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IProduct UpdateProduct(IProduct product)
        {
            throw new NotImplementedException();
        }
    }
}