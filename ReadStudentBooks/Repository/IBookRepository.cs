using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;

namespace ReadStudentBooks.Repository
{
    public interface IBookRepository
    {
        public IQueryable<Book> GetBooks();
        public IQueryable<Book> GetBooksByUsername(string username);
        public Book GetBook(int id);
        public Book AddBook(AddBookDto book);
        public Book UpdateBook(UpdateBookDto book);
        public void DeleteBook(int id);
    }
}
