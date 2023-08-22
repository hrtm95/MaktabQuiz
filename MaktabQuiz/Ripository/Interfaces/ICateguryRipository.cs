using MaktabQuiz.Models;

namespace MaktabQuiz.Ripository.Interfaces
{
    public interface ICateguryRipository
    {
        Task<List<Category>> GetAllCategury();
        Task<Category> GetCateguryById(int id);
        Task AddCategury(Category category);
        Task UpdateCategury(Category category);
        Task DeleteCategury(int id);
    }
}
