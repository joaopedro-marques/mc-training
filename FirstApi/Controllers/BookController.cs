using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        static private List<Book> books = new List<Book>
        {
            new Book
           {
                Id = 1,
                Title = "Dom Casmurro",
                Author =  "Machado de Assis",
                YearPublished = 1899
            },
            new Book
           {
                Id= 2,
                Title= "1984",
                Author= "George Orwell",
                YearPublished= 1949
            },
            new Book
            {
                Id= 3,
                Title= "O Nome do Vento",
                Author= "Patrick Rothfuss",
                YearPublished= 2007
            },
            new Book
            {
                Id= 4,
                Title= "Cem Anos de Solidão",
                Author= "Gabriel García Márquez",
                YearPublished= 1967
            },
            new Book
            {
                Id= 5,
                Title= "O Guia do Mochileiro das Galáxias",
                Author= "Douglas Adams",
                YearPublished= 1979
            }
        };

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> AddBook(Book newBook)
        {
            if (newBook == null)
                return BadRequest();
            books.Add(newBook);
            return CreatedAtAction(nameof(GetBook), new { id = newBook.Id }, newBook);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book updatedBook)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return BadRequest();
            book.Id = updatedBook.Id;
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.YearPublished = updatedBook.YearPublished;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return BadRequest();
            books.Remove(book);
            return NoContent();
        }
    }
}