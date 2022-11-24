using ReadStudentBooks.Data;
using ReadStudentBooks.Models;

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
            return _db.Books.First(book => book.Id == id);
        }

        public Book AddBook(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return book;
        }

        public Book UpdateBook(Book book)
        {
            _db.Books.Update(book);
            _db.SaveChanges();
            return book;
        }

        public void DeleteBook(int id)
        {
            Book book = _db.Books.First(book => book.Id == id);
            _db.Books.Remove(book);
            _db.SaveChanges();
        }

    }
}
