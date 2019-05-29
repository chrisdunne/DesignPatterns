using DesignPatterns.Other.Repository;
using NUnit.Framework;

namespace DesignPatterns.Tests.Other
{
    [TestFixture]
    public class Repository
    {
        private IProductRepository _repository;

        public Repository()
        {
            _repository = new CacheProductRepository();
        }

        [Test]
        public void WhenGetProductById_ReturnProduct()
        {
        }

        [Test]
        public void WhenGetAllProducts_ReturnIEnummerableOfProducts()
        {
        }

        [Test]
        public void WhenProductAdded_CheckAddedToIEnummerable()
        {
        }

        [Test]
        public void WhenProductDeleted_CheckRemovedFromIEnummerable()
        {
        }

        [Test]
        public void WhenProductUpdated_CheckGetProductReturnsNewProductValues()
        {
        }
    }
}