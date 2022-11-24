using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadStudentBooks.Data;
using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;

namespace ReadStudentBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public readonly ApplicationDbContext _db;
        public BooksController(ApplicationDbContext _db) 
        {
            this._db = _db;    
        }

        [HttpGet]
        public IQueryable<Book> getAllBooks()
        {
            return _db.Books;
        }

        [HttpPost]
        public Book addBook(BookDto bookDto)
        {
            Book book = new Book(
                bookDto.Title, 
                bookDto.Author, 
                bookDto.Content, 
                bookDto.DatePublished);
            _db.Add(book);
            _db.SaveChanges();
            return book;
        }
    }
}
