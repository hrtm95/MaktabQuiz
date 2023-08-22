using MaktabQuiz.Models;
using MaktabQuiz.Ripository.Interfaces;

namespace MaktabQuiz.Ripository.Ripositorys
{
    public class ProductRipository : IProductRipository
    {
        public Task AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
