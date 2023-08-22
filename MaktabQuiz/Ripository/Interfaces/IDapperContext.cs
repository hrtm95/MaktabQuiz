using Microsoft.Data.SqlClient;
using System.Data;

namespace MaktabQuiz.Ripository.Interfaces
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}
