using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


[ApiController]
[Route("[controller]")]
public class JournalController : ControllerBase
{
    private readonly IRepository<Book> _bookRepository;

    public JournalController(IRepository<Book> bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Book>> GetAll()
    {
        return await _bookRepository.GetAll();
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        try
        {
            var book = await _bookRepository.Get(id);
            return Ok(book);
        }
        catch (Exception)
        {
            return NotFound($"No such book at {id}");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        try
        {
            await _bookRepository.Get(id);
        }
        catch (Exception)
        {
            return NotFound($"Could not delete as {id} does not exist");
        }
        _bookRepository.Delete(id);

        return Ok();

    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(long id, [FromBody] Book book)
    {
        try
        {
            var book1 = await _bookRepository.Update(new Book { Id = id, Title = book.Title, Author = book.Author });
            return Ok(book1);
        }
        catch (Exception)
        {
            // experiment
            return BadRequest("Update failed");
        }

    }

    [HttpPost]
    public async Task<IActionResult> Insert([FromBody] Book book)
    {
        try
        {
            var book1 = await _bookRepository.Insert(book);
            return Ok(book1);
        }
        catch (Exception)
        {
            return BadRequest("Invalid entry");
        }
    }

