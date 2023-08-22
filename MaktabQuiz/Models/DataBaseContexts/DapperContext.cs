using Microsoft.Data.SqlClient;
using System.Data;

namespace MaktabQuiz.Models.DataBaseContexts{
    public class DapperContext
    {
        private readonly IConfiguration _iConfiguration;
        private readonly string _connString;
        public DapperContext(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
            _connString = _iConfiguration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connString);
    }
}
