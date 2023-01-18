using Microsoft.CSharp.RuntimeBinder;

namespace ReadStudentBooks.Models.Exceptions
{
    public class BookIdDoNotExistException : RuntimeBinderException
    {
        public BookIdDoNotExistException(int Id): base("Book with id" + Id + " do not exist") { }
    }
}
