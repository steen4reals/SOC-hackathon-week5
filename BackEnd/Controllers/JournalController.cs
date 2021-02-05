using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace BackEnd
{
    [ApiController]

    public class JournalController : ControllerBase
    {
        private readonly IRepository<Journal> _journalRepository;

        public JournalController(IRepository<Journal> journalRepository)
        {
            _journalRepository = journalRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Journal>> GetAll()
        {
            return await _journalRepository.GetAll();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var journal = await _journalRepository.Get(id);
                return Ok(journal);
            }
            catch (Exception)
            {
                return NotFound($"No such journal at {id}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                await _journalRepository.Get(id);
            }
            catch (Exception)
            {
                return NotFound($"Could not delete as {id} does not exist");
            }
            _journalRepository.Delete(id);

            return Ok();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] Journal journal)
        {
            try
            {
                var journal1 = await _journalRepository.Update(new Journal { Id = id, JournalEntry = journal.JournalEntry });
                return Ok(journal1);
            }
            catch (Exception)
            {
                // experiment
                return BadRequest("Update failed");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Journal journal)
        {
            try
            {
                var journal1 = await _journalRepository.Insert(journal);
                return Ok(journal1);
            }
            catch (Exception)
            {
                return BadRequest("Invalid entry");
            }
        }

    }
}