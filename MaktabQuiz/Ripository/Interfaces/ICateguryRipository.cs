using MaktabQuiz.Models;

namespace MaktabQuiz.Ripository.Interfaces
{
    public interface ICateguryRipository
    {
        Task<List<Category>> GetAllProducts();
        Task AddProduct(Category category);
        Task UpdateProduct(Category category);
        Task DeleteProduct(Category category);
    }
}
