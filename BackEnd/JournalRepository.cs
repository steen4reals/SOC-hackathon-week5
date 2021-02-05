using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;
public class JournalRepository : BaseRepository, IRepository<Journal>
{

    public JournalRepository(IConfiguration configuration) : base(configuration) { }

    public async Task<IEnumerable<Journal>> GetAll()
    {
        using var connection = CreateConnection();
        IEnumerable<Journal> journal = await connection.QueryAsync<Journal>("SELECT * FROM journal;");
        return journal;
    }


    public async void Delete(long id)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM journal WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Journal> Get(long id)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Journal>("SELECT * FROM journal WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Journal> Update(Journal journal)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Journal>("UPDATE journal SET Title = @Title, Author = @Author WHERE Id = @Id RETURNING *", journal);
    }

    public async Task<Journal> Insert(Journal journal)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Journal>("INSERT INTO journal (Title, Author) VALUES (@Title, @Author) RETURNING *;", journal);
    }
}

