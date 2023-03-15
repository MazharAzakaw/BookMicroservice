using BookMicroservice.Models;
using Microsoft.AspNetCore.Mvc;
using BookMicroservice.Repository;

namespace BookMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repository;
        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _repository.GetAllBooksAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetById(int id)
        {
            var book = await _repository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
        [HttpPost]
        public async Task<ActionResult<Book>> Create(Book book)
        {
            await _repository.AddBookAsync(book);
            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }
            await _repository.UpdateBookAsync(book);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _repository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            await _repository.DeleteBookAsync(id);
            return NoContent();
        }
    }
}