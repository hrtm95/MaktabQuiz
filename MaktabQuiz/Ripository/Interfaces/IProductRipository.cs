using MaktabQuiz.Models;

namespace MaktabQuiz.Ripository.Interfaces
{
    public interface IProductRipository
    {
        Task<List<Product>> GetAllProducts();
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(Product product);

    }
}
