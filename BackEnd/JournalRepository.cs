using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;
using System;

namespace BackEnd
{
    public class JournalRepository : BaseRepository, IRepository<Journal>
    {

        public JournalRepository(IConfiguration configuration) : base(configuration) { }

        public async Task<IEnumerable<Journal>> GetAll()
        {
            using var connection = CreateConnection();
            IEnumerable<Journal> journal = await connection.QueryAsync<Journal>("SELECT * FROM Journal;");
            return journal;
        }


        public async void Delete(long id)
        {
            using var connection = CreateConnection();
            await connection.ExecuteAsync("DELETE FROM Journal WHERE Id = @Id;", new { Id = id });
        }

        public async Task<Journal> Get(long id)
        {
            using var connection = CreateConnection();
            return await connection.QuerySingleAsync<Journal>("SELECT * FROM Journal WHERE Id = @Id;", new { Id = id });
        }

        public async Task<Journal> Update(Journal journal)
        {
            using var connection = CreateConnection();
            return await connection.QuerySingleAsync<Journal>("UPDATE Journal SET JournalEntry =@JournalEntry WHERE Id = @Id RETURNING *", journal);
        }

        public async Task<Journal> Insert(Journal journal)
        {
            using var connection = CreateConnection();
            return await connection.QuerySingleAsync<Journal>("INSERT INTO Journal (JournalEntry) VALUES (@JournalEntry) RETURNING *;", journal);
        }
    }
}
