namespace DesignPatterns.Other.Repository
{
    public class Product : IProduct
    {
        private IProductRepository _repository;

        public Product(IProductRepository repository)
        {
            _repository = repository;
        }
    }
}