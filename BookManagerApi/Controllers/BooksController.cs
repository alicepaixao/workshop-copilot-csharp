using Microsoft.AspNetCore.Mvc;
using BookManagerApi.Models;
using BookManagerApi.Data;
using System.Collections.Generic;
using System.Linq;

namespace BookManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookContext _context;

        public BooksController(BookContext context)
        {
            _context = context;

            if (_context.Books.Count() == 0)
            {
                // Adicionando livros padrão se a lista estiver vazia
                _context.Books.Add(new Book { Title = "1984", Author = "George Orwell", PublicationYear = 1949, Genre = "Dystopia", AvailableCopies = 3 });
                _context.Books.Add(new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", PublicationYear = 1951, Genre = "Fiction", AvailableCopies = 5 });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Book>> GetAll() =>
            _context.Books.ToList();

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            var book = _context.Books.Find(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            var existingBook = _context.Books.Find(id);
            if (existingBook == null)
            {
                return NotFound();
            }

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.PublicationYear = book.PublicationYear;
            existingBook.Genre = book.Genre;
            existingBook.AvailableCopies = book.AvailableCopies;

            _context.Books.Update(existingBook);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);

            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
