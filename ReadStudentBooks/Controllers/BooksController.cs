using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadStudentBooks.Data;
using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;
using ReadStudentBooks.Repository;

namespace ReadStudentBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public readonly IBookRepository bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        public IQueryable<Book> GetAllBooks()
        {
            return bookRepository.GetBooks();
        }

        [HttpGet("{id}")]
        public Book GetBook([FromQuery] int id)
        {
            return bookRepository.GetBook(id);
        }

        [HttpGet("books-by-username/{username}")]
        public IQueryable<Book> GetBooksByUsername([FromQuery] string username) 
        {
            return bookRepository.GetBooksByUsername(username);
        }

        [HttpPost("add-book")]
        public Book AddBook([FromBody] AddBookDto bookDto)
        {
            return bookRepository.AddBook(bookDto);
        }

        [HttpPut("update-book")]
        public Book UpdateBook(UpdateBookDto updateBookDto)
        {
            return bookRepository.UpdateBook(updateBookDto);
        }

        [HttpDelete("delete-by-id/{id}")]
        public void DeleteBook(int id)
        {
            bookRepository.DeleteBook(id);
        }
    }
}
