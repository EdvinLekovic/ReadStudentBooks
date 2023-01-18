using Microsoft.IdentityModel.Tokens;
using ReadStudentBooks.Data;
using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;
using ReadStudentBooks.Models.Exceptions;

namespace ReadStudentBooks.Repository
{
    public class BookRepository : IBookRepository
    {
        public readonly ApplicationDbContext _db;

        public BookRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<Book> GetBooks()
        {
            return _db.Books;
        }

        public Book GetBook(int id)
        {
            return _db.Books.FirstOrDefault(book => book.Id == id);
        }

        public Book AddBook(AddBookDto bookDto)
        {
            Book book = new Book(
                bookDto.Title,
                bookDto.Author,
                bookDto.Description,
                bookDto.Content,
                bookDto.Image,
                bookDto.Price);

            _db.Books.Add(book);
            _db.SaveChanges();
            return book;
        }

        public Book UpdateBook(UpdateBookDto updateBookDto)
        {
            if(!_db.Books.Any(book => book.Id == updateBookDto.Id))
            {
                throw new BookIdDoNotExistException(updateBookDto.Id);
            }

            Book book = _db.Books.First(book => book.Id == updateBookDto.Id);
            if (!updateBookDto.Author.IsNullOrEmpty())
            {
                book.Author = updateBookDto.Author;
            }

            if (!updateBookDto.Title.IsNullOrEmpty())
            {
                book.Title = updateBookDto.Title;
            }

            if (!updateBookDto.Description.IsNullOrEmpty())
            {
                book.Description = updateBookDto.Description;

            }

            _db.Books.Update(book);
            _db.SaveChanges();
            return book;
        }

        public void DeleteBook(int id)
        {
            if (!_db.Books.Any(book => book.Id == id))
            {
                throw new BookIdDoNotExistException(id);
            }

            Book book = _db.Books.First(book => book.Id == id);
            _db.Books.Remove(book);
            _db.SaveChanges();
        }

        public IQueryable<Book> GetBooksByUsername(string username)
        {
            if (!_db.Books.Any(book => book.Users.Any(user => user.UserName.Equals(username))))
            {
                throw new UserDontExistException();
            }

            return _db.Books.Where(book => 
            book.Users.Exists(user => user.UserName.Equals(username)));
        }
    }
}
