using Dapper;
using MaktabQuiz.Models;
using MaktabQuiz.Models.Database;
using MaktabQuiz.Ripository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MaktabQuiz.Ripository.Ripositorys
{
    public class CategoryRepository : ICateguryRipository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IDapperContext _dopperContext;
        public CategoryRepository(ApplicationDbContext applicationDbContext, IDapperContext dapperContext )
        {
            _dopperContext = dapperContext;
            _applicationDbContext = applicationDbContext;

        }

        public Task AddCategury(Category category)
        {
            throw new NotImplementedException();
        }


        public Task DeleteCategury(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetAllCategury()
        {
            var query = "select * from Categories";
            using var connection = _dopperContext.CreateConnection();
            var result = await connection.QueryAsync<Category>(query);
            return result.ToList();
        }

        public async Task<Category> GetCateguryById(int id)
        {
            return _applicationDbContext.Categorys.FirstOrDefault(c => c.Id == id); ;
        }

        public Task UpdateCategury(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
