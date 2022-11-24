using ReadStudentBooks.Models;

namespace ReadStudentBooks.Repository
{
    public interface IBookRepository
    {
        public IQueryable<Book> GetBooks();
        public Book GetBook(int id);
        public Book AddBook(Book book);
        public Book UpdateBook(Book book);
        public void DeleteBook(int id);
    }
}
