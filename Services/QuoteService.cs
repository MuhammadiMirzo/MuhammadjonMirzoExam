
namespace Services;
using Npgsql;
using Dapper;


public class QuoteService
{
    private string connectionString = "Server=127.0.0.1;Port=5432;Database=Exam;User Id=postgres;Password=1234;";

    private NpgsqlConnection  _connection;
    public QuoteService()
    {
        _connection = new NpgsqlConnection(connectionString);
        
    }


    public async Task<int> DeleteQuoteById(int id)
     {
         using (_connection)
         {
            var sql = $"delete from quote where id = {id}"; 
            var res =await  _connection.ExecuteAsync(sql);
            return res;
         }
     }
     public async Task<List<GetQuotes>> GetQuotes()
    {
        using(_connection)
        {
            var sql =  $"select q.id,q.Author, q.QuoteText ,; c.categoryname  from quote as q  join category c on c.id = c.id";

            var res =await _connection.QueryAsync<GetQuotes>(sql);
            return res.ToList(); 
        }
    }
}
